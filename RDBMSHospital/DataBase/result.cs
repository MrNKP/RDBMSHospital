namespace RDBMSHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("result")]
    public partial class result
    {
        public int id { get; set; }

        public int patientId { get; set; }

        public int doctorId { get; set; }

        [Required]
        [StringLength(255)]
        public string diagnosis { get; set; }

        public bool outpatient_treatment { get; set; }

        public int count_without_work { get; set; }

        public bool clinical_account { get; set; }

        [Column(TypeName = "date")]
        public DateTime start { get; set; }

        [Column(TypeName = "date")]
        public DateTime predicted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fact { get; set; }

        public virtual doctor doctor { get; set; }

        public virtual patient patient { get; set; }
    }
}
