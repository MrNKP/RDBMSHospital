namespace RDBMSHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtPatient")]
    public partial class ExtPatient
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string family_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string father_name { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime bitrh { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(255)]
        public string soc_status { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(255)]
        public string curr_status { get; set; }
    }
}
