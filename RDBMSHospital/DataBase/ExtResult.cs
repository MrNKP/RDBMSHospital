namespace RDBMSHospital
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtResult")]
    public partial class ExtResult
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
        [Column(Order = 4)]
        [StringLength(255)]
        public string Expr1 { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(255)]
        public string Expr2 { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(255)]
        public string Expr3 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string diagnosis { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool outpatient_treatment { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int count_without_work { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool clinical_account { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "date")]
        public DateTime start { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "date")]
        public DateTime predicted { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fact { get; set; }
    }
}
