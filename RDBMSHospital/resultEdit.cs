using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDBMSHospital
{
    public partial class resultEdit : Form
    {
        result r;
        HospitalContext db = new HospitalContext();
        public resultEdit()
        {
            InitializeComponent();
            List<string> patientR = new List<string>();
            for (int i = 0; i < db.patients.ToList().Count; i++) patientR.Add(db.patients.ToList()[i].family_name + " " + db.patients.ToList()[i].name + " " + db.patients.ToList()[i].father_name);
            patientComboBox.DataSource = patientR;
            //patientComboBox.SelectedItem = r.patient.family_name + " " + r.patient.name + " " + r.patient.father_name;
            List<string> doctorR = new List<string>();
            for (int i = 0; i < db.doctors.ToList().Count; i++) doctorR.Add(db.doctors.ToList()[i].family_name + " " + db.doctors.ToList()[i].name + " " + db.doctors.ToList()[i].father_name);
            doctorComboBox.DataSource = doctorR;
            //doctorComboBox.SelectedItem = r.doctor.family_name + " " + r.doctor.name + " " + r.doctor.father_name;
        }
        public resultEdit(result nr)
        {
            InitializeComponent();
            r = nr;
            //patientFamilyNameTextBox.Text = r.patient.family_name;
            //patientNameTextBox.Text = r.patient.name;
            //patientFatherNameTextBox.Text = r.patient.father_name;
            //doctorFamilyNameTextBox.Text = r.doctor.family_name;
            //doctorNameTextBox.Text = r.doctor.name;
            //doctorFatherNameTextBox.Text = r.doctor.father_name;
            List<string> patientR = new List<string>();
            for (int i = 0; i < db.patients.ToList().Count; i++) patientR.Add(db.patients.ToList()[i].family_name + " " + db.patients.ToList()[i].name + " " + db.patients.ToList()[i].father_name);
            patientComboBox.DataSource = patientR;
            patientComboBox.SelectedItem = r.patient.family_name + " " + r.patient.name + " " + r.patient.father_name;
            List<string> doctorR = new List<string>();
            for (int i = 0; i < db.doctors.ToList().Count; i++) doctorR.Add(db.doctors.ToList()[i].family_name + " " + db.doctors.ToList()[i].name + " " + db.doctors.ToList()[i].father_name);
            doctorComboBox.DataSource = doctorR;
            doctorComboBox.SelectedItem = r.doctor.family_name + " " + r.doctor.name + " " + r.doctor.father_name;
            diagnosisTextBox.Text = r.diagnosis;
            outpatientCheckBox.Checked = r.outpatient_treatment;
            countDaysTextBox.Text = Convert.ToString(r.count_without_work);
            clinicalAccountCheckBox.Checked = r.clinical_account;
            startDateTextBox.Text = Convert.ToString(r.start);
            predictedDateTextBox.Text = Convert.ToString(r.predicted);
            factDateTextBox.Text = Convert.ToString(r.fact);
        }
    }
}
