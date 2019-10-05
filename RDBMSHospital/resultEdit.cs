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
        public resultEdit()
        {
            InitializeComponent();
        }
        public resultEdit(result nr)
        {
            InitializeComponent();
            r = nr;
            patientFamilyNameTextBox.Text = r.patient.family_name;
            patientNameTextBox.Text = r.patient.name;
            patientFatherNameTextBox.Text = r.patient.father_name;
            doctorFamilyNameTextBox.Text = r.doctor.family_name;
            doctorNameTextBox.Text = r.doctor.name;
            doctorFatherNameTextBox.Text = r.doctor.father_name;
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
