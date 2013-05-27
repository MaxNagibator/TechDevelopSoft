using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	public interface IPatientImporter
	{
        IList<PatientImportData> ImportedData { get; }
        void Import();
	}
}
