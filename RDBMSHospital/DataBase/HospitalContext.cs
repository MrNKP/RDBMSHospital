namespace RDBMSHospital
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
            : base("name=HospitalContext")
        {
        }

        public virtual DbSet<current_status> current_status { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<doctor_position> doctor_position { get; set; }
        public virtual DbSet<doctor_specialization> doctor_specialization { get; set; }
        public virtual DbSet<doctor_to_specialization> doctor_to_specialization { get; set; }
        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<patient_doctor> patient_doctor { get; set; }
        public virtual DbSet<result> results { get; set; }
        public virtual DbSet<social_status> social_status { get; set; }
        public virtual DbSet<ExtDoctor> ExtDoctors { get; set; }
        public virtual DbSet<ExtDoctorWithPos> ExtDoctorWithPos { get; set; }
        public virtual DbSet<ExtDoctorWithSpec> ExtDoctorWithSpecs { get; set; }
        public virtual DbSet<ExtPatient> ExtPatients { get; set; }
        public virtual DbSet<ExtPatientDoctor> ExtPatientDoctors { get; set; }
        public virtual DbSet<ExtResult> ExtResults { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<current_status>()
                .Property(e => e.curr_status)
                .IsUnicode(false);

            modelBuilder.Entity<current_status>()
                .HasMany(e => e.patients)
                .WithRequired(e => e.current_status)
                .HasForeignKey(e => e.cur_status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.family_name)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .Property(e => e.father_name)
                .IsUnicode(false);

            modelBuilder.Entity<doctor>()
                .HasMany(e => e.doctor_to_specialization)
                .WithRequired(e => e.doctor)
                .HasForeignKey(e => e.docID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<doctor>()
                .HasMany(e => e.patient_doctor)
                .WithRequired(e => e.doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<doctor>()
                .HasMany(e => e.results)
                .WithRequired(e => e.doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<doctor_position>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<doctor_position>()
                .HasMany(e => e.doctors)
                .WithRequired(e => e.doctor_position)
                .HasForeignKey(e => e.position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<doctor_specialization>()
                .Property(e => e.specialization)
                .IsUnicode(false);

            modelBuilder.Entity<doctor_specialization>()
                .HasMany(e => e.doctor_to_specialization)
                .WithRequired(e => e.doctor_specialization)
                .HasForeignKey(e => e.specID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.family_name)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.father_name)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .HasMany(e => e.patient_doctor)
                .WithRequired(e => e.patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<patient>()
                .HasMany(e => e.results)
                .WithRequired(e => e.patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<result>()
                .Property(e => e.diagnosis)
                .IsUnicode(false);

            modelBuilder.Entity<social_status>()
                .Property(e => e.soc_status)
                .IsUnicode(false);

            modelBuilder.Entity<social_status>()
                .HasMany(e => e.patients)
                .WithRequired(e => e.social_status)
                .HasForeignKey(e => e.soc_status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExtDoctor>()
                .Property(e => e.family_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctor>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctor>()
                .Property(e => e.father_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctor>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctor>()
                .Property(e => e.specialization)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctorWithPos>()
                .Property(e => e.family_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctorWithPos>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctorWithPos>()
                .Property(e => e.father_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctorWithPos>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctorWithSpec>()
                .Property(e => e.family_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctorWithSpec>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctorWithSpec>()
                .Property(e => e.father_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtDoctorWithSpec>()
                .Property(e => e.specialization)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatient>()
                .Property(e => e.family_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatient>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatient>()
                .Property(e => e.father_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatient>()
                .Property(e => e.soc_status)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatient>()
                .Property(e => e.curr_status)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatientDoctor>()
                .Property(e => e.patientFamilyName)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatientDoctor>()
                .Property(e => e.patientName)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatientDoctor>()
                .Property(e => e.patientFatherName)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatientDoctor>()
                .Property(e => e.doctorFamilyName)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatientDoctor>()
                .Property(e => e.doctorName)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatientDoctor>()
                .Property(e => e.doctorFatherName)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatientDoctor>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<ExtPatientDoctor>()
                .Property(e => e.specialization)
                .IsUnicode(false);

            modelBuilder.Entity<ExtResult>()
                .Property(e => e.family_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtResult>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtResult>()
                .Property(e => e.father_name)
                .IsUnicode(false);

            modelBuilder.Entity<ExtResult>()
                .Property(e => e.Expr1)
                .IsUnicode(false);

            modelBuilder.Entity<ExtResult>()
                .Property(e => e.Expr2)
                .IsUnicode(false);

            modelBuilder.Entity<ExtResult>()
                .Property(e => e.Expr3)
                .IsUnicode(false);

            modelBuilder.Entity<ExtResult>()
                .Property(e => e.diagnosis)
                .IsUnicode(false);
        }
    }
}
