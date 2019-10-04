namespace RDBMSHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class doctor_to_specialization
    {
        public int id { get; set; }

        public int docID { get; set; }

        public int specID { get; set; }

        public virtual doctor doctor { get; set; }

        public virtual doctor_specialization doctor_specialization { get; set; }
    }
}
