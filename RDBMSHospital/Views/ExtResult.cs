using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDBMSHospital.Views
{
    class ExtResult
    {
        public int id { get; set; }
        public string patientFamilyName { get; set; }
        public string patientName { get; set; }
        public string patientFatherName { get; set; }
        public string doctorFamilyName { get; set; }
        public string doctorName { get; set; }
        public string doctorFatherName { get; set; }
        public string diagnosis { get; set; }
        public bool outpatient_treatment { get; set; }
        public int count_without_work { get; set; }
        public bool clinical_account { get; set; }
        public DateTime start { get; set; }
        public DateTime predicted { get; set; }
        public DateTime? fact { get; set; }
        /*
        //Methods
        public List<ExtResult> GetExtResults()
        {
            var k = 
        }
        */
    }
}
