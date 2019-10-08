using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDBMSHospital.Views
{
    class ExtDoctor
    {
        public int id { get; set; }
        public string familyName { get; set; }
        public string name { get; set; }
        public string fatherName { get; set; }
        public string position { get; set; }
        public int? qualification { get; set; }
    }
}
