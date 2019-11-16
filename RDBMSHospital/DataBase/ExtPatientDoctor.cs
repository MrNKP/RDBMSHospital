namespace RDBMSHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtPatientDoctor")]
    public partial class ExtPatientDoctor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string patientFamilyName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string patientName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string patientFatherName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string doctorFamilyName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(255)]
        public string doctorName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(255)]
        public string doctorFatherName { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string position { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(255)]
        public string specialization { get; set; }
    }
}
