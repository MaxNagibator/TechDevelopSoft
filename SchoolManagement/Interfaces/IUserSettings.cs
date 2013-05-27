using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IUserSettings
    {
        void Init();
        event EventHandler OnClose;
        event EventHandler OnSave;
        int UserID { get; set; }
    }
}
