using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDBMSHospital.Views
{
    class ExtPatient
    {
        public int id { get; set; }
        public string familyName { get; set; }
        public string name { get; set; }
        public string fatherName { get; set; }
        public DateTime birth { get; set; }
        public string soc_status { get; set; }
        public string curr_status { get; set; }
    }
}
