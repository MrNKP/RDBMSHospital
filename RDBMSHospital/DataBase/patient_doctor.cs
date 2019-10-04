namespace RDBMSHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class patient_doctor
    {
        public int id { get; set; }

        public int patientId { get; set; }

        public int doctorId { get; set; }

        public virtual doctor doctor { get; set; }

        public virtual patient patient { get; set; }
    }
}
