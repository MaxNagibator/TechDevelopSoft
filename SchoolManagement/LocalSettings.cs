using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SchoolManagement
{
    public class LocalSettings
    {
        private const string ROOT_NODE_NAME = "Main";
        private const string CONNECTION_STRING_NAME = "ConnectionString";
        private const string ROOT_LOGIN_NAME = "RootLogin";
        private const string ROOT_PASS_NAME = "RootPass";
        private const string SETTINGS_FILE_NAME = "\\settings.xml";
        private string ConfigurationFolderPath{get;set;}
        private string _configurationFilePath;
        private XDocument _configurationDocument;
        private XElement _rootElement;

        public LocalSettings()
        {
            ReadSettingsFileAndLoadSettings(".\\Data");
        }

        private void ReadSettingsFileAndLoadSettings(string folderPath)
        {
            FormConfigurationFolderAndFilePaths(folderPath);
            LoadConfigurationDocument();
            LoadRootElement();
        }
        private void LoadConfigurationDocument()
        {
            try
            {
                _configurationDocument = XDocument.Load(_configurationFilePath);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Configuration file " + _configurationFilePath + " not found, creating new document");
                CreateConfigurationDocument();
            }
        }

        private void CreateConfigurationDocument()
        {
            _configurationDocument = new XDocument(
                new XElement(ROOT_NODE_NAME,
                    new XElement(SETTINGS_FILE_NAME)));
        }

        private void LoadRootElement()
        {
            _rootElement = _configurationDocument.Root;
            if (_rootElement == null)
            {
                CreateRootElement();
            }
        }

        private void CreateRootElement()
        {
            _rootElement = new XElement(ROOT_NODE_NAME);
            _configurationDocument.AddFirst(_rootElement);
        }

        public void FormConfigurationFolderAndFilePaths(string folderPath)
        {
            ConfigurationFolderPath = folderPath;
            _configurationFilePath = ConfigurationFolderPath + SETTINGS_FILE_NAME;
        }

        public string ConnectionString
        {
            get
            {
                return ParseNode(CONNECTION_STRING_NAME);
            }
            set
            {
                SetNodeValue(CONNECTION_STRING_NAME, value);
            }
        }
        public string RootLogin
        {
            get
            {
                return ParseNode(ROOT_LOGIN_NAME);
            }
            set
            {
                SetNodeValue(ROOT_LOGIN_NAME, value);
            }
        }

        public string RootPass
        {
            get
            {
                return ParseNode(ROOT_PASS_NAME);
            }
            set
            {
                SetNodeValue(ROOT_PASS_NAME, value);
            }
        }

        private string ParseNode(string nodeName)
        {
            XElement nodeElement = GetOrCreateNodeIfMissed(nodeName);
            return nodeElement.Value;
        }

        private void SetNodeValue(string nodeName, object value)
        {
            XElement nodeElement = GetOrCreateNodeIfMissed(nodeName);
            nodeElement.Value = "" + value;
        }

        private XElement GetOrCreateNodeIfMissed(string nodeName)
        {
            XElement nodeElement = _rootElement.Element(nodeName);
            if (nodeElement == null)
            {
                nodeElement = new XElement(nodeName);
                _rootElement.Add(nodeElement);
            }
            return nodeElement;
        }
    }
}
