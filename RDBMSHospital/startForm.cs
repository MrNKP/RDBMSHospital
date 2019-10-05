using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using RDBMSHospital.DataBaseManage;

namespace RDBMSHospital
{
    public partial class startForm : Form
    {
        HospitalContext db;
        DBManage dbm;
        public startForm()
        {
            InitializeComponent();
            db = new HospitalContext();
            dbm = new DBManage(db);
        }

        private void patientShowBtn_Click(object sender, EventArgs e)
        {
            patiencesDataGridView.DataSource = db.patients.ToList();
        }

        private void patiencesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(patiencesDataGridView.CurrentRow.Cells[0].Value);
            //7.8
            if (e.ColumnIndex == 7) //MessageBox.Show("Edit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                patient locp = db.patients.Find(id);
                using (patientEdit frm = new patientEdit(locp))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        //Edit
                        if (dbm.EditPatient(id, frm.familyNameTextBox.Text, frm.nameTextBox.Text, frm.fatherNameTextBox.Text, Convert.ToDateTime(frm.birthTextBox.Text), db.social_status.Where(p => p.soc_status.Equals(frm.socStatusTextBox.Text)).First().id, db.current_status.Where(p => p.curr_status.Equals(frm.currStatusTextBox.Text)).First().id))
                            MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        patiencesDataGridView.DataSource = db.patients.ToList();
                    }
                }
            }
            if (e.ColumnIndex == 8) //MessageBox.Show("Delete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                // Delete
                if (dbm.DeletePatient(id))
                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                patiencesDataGridView.DataSource = db.patients.ToList();
            }
        }

        private void patientAddBtn_Click(object sender, EventArgs e)
        {
            using (patientEdit frm = new patientEdit())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (dbm.AddPatient(frm.familyNameTextBox.Text, frm.nameTextBox.Text, frm.fatherNameTextBox.Text, Convert.ToDateTime(frm.birthTextBox.Text), db.social_status.Where(p => p.soc_status.Equals(frm.socStatusTextBox.Text)).First().id, db.current_status.Where(p => p.curr_status.Equals(frm.currStatusTextBox.Text)).First().id) == null)
                        MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    patiencesDataGridView.DataSource = db.patients.ToList();
                }
            }
        }

        private void doctorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(doctorsDataGridView.CurrentRow.Cells[0].Value);
            //6.7
            if (e.ColumnIndex == 6)
            {
                doctor locd = db.doctors.Find(id);
                //Edit
                using (doctorEdit frm = new doctorEdit(locd))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (dbm.EditDoctor(id, frm.familyNameTextBox.Text, frm.nameTextBox.Text, frm.fatherNameTextBox.Text, db.doctor_position.Where(p => p.position.Equals(frm.posTextBox.Text)).First().id, frm.qualifTextBox.Text))
                            MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        doctorsDataGridView.DataSource = db.doctors.ToList();
                    }
                }
            }
            if (e.ColumnIndex == 7)
            {
                //Delete
                if (dbm.DeleteDoctor(id))
                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doctorsDataGridView.DataSource = db.doctors.ToList();
            }
        }

        private void doctorShowBtn_Click(object sender, EventArgs e)
        {
            doctorsDataGridView.DataSource = db.doctors.ToList();
        }

        private void doctorAddBtn_Click(object sender, EventArgs e)
        {
            using (doctorEdit frm = new doctorEdit())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (dbm.AddDoctor(frm.familyNameTextBox.Text, frm.nameTextBox.Text, frm.fatherNameTextBox.Text, db.doctor_position.Where(p => p.position.Equals(frm.posTextBox.Text)).First().id, frm.qualifTextBox.Text) == null)
                        MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    doctorsDataGridView.DataSource = db.doctors.ToList();
                }
            }
        }

        private void resultShowBtn_Click(object sender, EventArgs e)
        {
            resultDataGridView.DataSource = db.results.ToList();
        }

        private void resultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(resultDataGridView.CurrentRow.Cells[0].Value);
            //12.13
            if (e.ColumnIndex == 12)
            {
                //Edit
                result locr = db.results.Find(id);
                using (resultEdit frm = new resultEdit(locr))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        patient p = db.patients.Where(p1 => (p1.family_name == frm.patientFamilyNameTextBox.Text) && (p1.name == frm.patientNameTextBox.Text) && (p1.father_name == frm.patientFatherNameTextBox.Text)).FirstOrDefault();
                        doctor d = db.doctors.Where(d1 => (d1.family_name == frm.doctorFamilyNameTextBox.Text) && (d1.name == frm.doctorNameTextBox.Text) && (d1.father_name == frm.doctorFatherNameTextBox.Text)).FirstOrDefault();
                        if (dbm.EditResult(id, p.id, d.id, frm.diagnosisTextBox.Text, frm.outpatientCheckBox.Checked, Convert.ToInt32(frm.countDaysTextBox.Text), frm.clinicalAccountCheckBox.Checked, Convert.ToDateTime(frm.startDateTextBox.Text), Convert.ToDateTime(frm.predictedDateTextBox.Text), frm.factDateTextBox.Text))
                            MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultDataGridView.DataSource = db.results.ToList();
                    }
                }
            }
            if (e.ColumnIndex == 13)
            {
                //Delete
                if (dbm.DeleteResult(id))
                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultDataGridView.DataSource = db.results.ToList();
            }
        }

        private void resultAddBtn_Click(object sender, EventArgs e)
        {
            using (resultEdit frm = new resultEdit())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    patient p = db.patients.Where(p1 => (p1.family_name == frm.patientFamilyNameTextBox.Text) && (p1.name == frm.patientNameTextBox.Text) && (p1.father_name == frm.patientFatherNameTextBox.Text)).FirstOrDefault();
                    doctor d = db.doctors.Where(d1 => (d1.family_name == frm.doctorFamilyNameTextBox.Text) && (d1.name == frm.doctorNameTextBox.Text) && (d1.father_name == frm.doctorFatherNameTextBox.Text)).FirstOrDefault();
                    if (dbm.AddResult(p.id, d.id, frm.diagnosisTextBox.Text, frm.outpatientCheckBox.Checked, Convert.ToInt32(frm.countDaysTextBox.Text), frm.clinicalAccountCheckBox.Checked, Convert.ToDateTime(frm.startDateTextBox.Text), Convert.ToDateTime(frm.predictedDateTextBox.Text), frm.factDateTextBox.Text) == null)
                        MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultDataGridView.DataSource = db.results.ToList();
                }
            }
        }
    }
}
