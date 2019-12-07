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
using System.Text.RegularExpressions;

namespace RDBMSHospital
{
    public partial class startForm : Form
    {
        HospitalContext db;
        DBManage dbm;
        string loggerUser;
        string loggerRole;
        public startForm()
        {
            InitializeComponent();
            db = new HospitalContext();
            dbm = new DBManage(db);
            loggerUser = "Guest";
            loggerRole = "Patient";
        }
        public startForm(string locLoggedUser, string locLoggedRole)
        {
            InitializeComponent();
            db = new HospitalContext();
            dbm = new DBManage(db);
            loggerUser = locLoggedUser;
            loggerRole = locLoggedRole;
            this.Text = "View DataBase --- " + loggerUser + " --- " + loggerRole;
            if (loggerRole != "Admin")
            {
                patientAddBtn.Visible = false;
                doctorAddBtn.Visible = false;
                resultAddBtn.Visible = false;
                EditPatient.Visible = false;
                DeletePatient.Visible = false;
                EditDoctor.Visible = false;
                DeleteDoctor.Visible = false;
                resultEdit.Visible = false;
                resultDelete.Visible = false;
            }
            if (loggerRole == "Doctor")
            {
                resultAddBtn.Visible = true;
            }
            if (loggerRole == "Patient")
            {
                patientShowBtn.Visible = false;
                //patiencesDataGridView.DataSource = null;
                resultShowBtn.Visible = false;
                //resultDataGridView.DataSource = null;
            }
        }

        private string cutSpacesAndUnprintChars(string str)
        {
            string res = str;

            // удаление начальных и конечных пробелов
            res = res.Trim(' ');
            // сокращение до одного пробела
            res = Regex.Replace(res, @"\s+", "");
            // отрезание некоторых ненужных символов
            res = Regex.Replace(res, @"\?+|\^+|\*+|;+|<+|>+", "");
            // удаление некоторых повторяющихся символов (сокращение до 1)
            res = Regex.Replace(res, @"(?<=,),+|(?<=\.)\.+|(?<=!)!+", "");
            // удаление цифр
            res = Regex.Replace(res, @"\d+", "");
            // удаление знаков препинания
            res = Regex.Replace(res, @"[-.?!)(,:/]", "");
            // удаление непечаток
            res = new string(res.Where(c => !char.IsControl(c)).ToArray());

            return res;
        }
        private string diagnosisCutSpacesAndUnprintChars(string str)
        {
            string res = str;

            // удаление начальных и конечных пробелов
            res = res.Trim(' ');
            // сокращение до одного пробела
            res = Regex.Replace(res, @"\s+", " ");
            // отрезание некоторых ненужных символов
            res = Regex.Replace(res, @"\?+|\^+|\*+|;+|<+|>+", "");
            // удаление некоторых повторяющихся символов (сокращение до 1)
            res = Regex.Replace(res, @"(?<=,),+|(?<=\.)\.+|(?<=!)!+", "");
            // удаление цифр
            res = Regex.Replace(res, @"\d+", "");
            // удаление знаков препинания
            res = Regex.Replace(res, @"[-.?!)(,:/]", "");
            // удаление непечаток
            res = new string(res.Where(c => !char.IsControl(c)).ToArray());

            return res;
        }
        private void reloadData()
        {
            db = new HospitalContext();
            dbm = new DBManage(db);
        }

        private void patientShowBtn_Click(object sender, EventArgs e)
        {
            //patiencesDataGridView.DataSource = db.patients.ToList();
            //patiencesDataGridView.DataSource = dbm.GetExtPatients();
            reloadData();
            patiencesDataGridView.DataSource = db.ExtPatients.ToList();
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
                        string familyName = frm.familyNameTextBox.Text;
                        string name = frm.nameTextBox.Text;
                        string fatherName = frm.fatherNameTextBox.Text;
                        familyName = cutSpacesAndUnprintChars(familyName);
                        name = cutSpacesAndUnprintChars(name);
                        fatherName = cutSpacesAndUnprintChars(fatherName);
                        if (dbm.EditPatient(id, familyName, name, fatherName, frm.birthDateTimePicker.Value, db.social_status.Where(p => p.soc_status.Equals(frm.socStatusComboBox.SelectedItem.ToString())).First().id, db.current_status.Where(p => p.curr_status.Equals(frm.currStatusComboBox.SelectedItem.ToString())).First().id))
                            MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //patiencesDataGridView.DataSource = db.patients.ToList();
                        //patiencesDataGridView.DataSource = dbm.GetExtPatients();
                        reloadData();
                        patiencesDataGridView.DataSource = db.ExtPatients.ToList();
                    }
                }
            }
            if (e.ColumnIndex == 8) //MessageBox.Show("Delete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                // Delete
                if (dbm.DeletePatient(id))
                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //patiencesDataGridView.DataSource = db.patients.ToList();
                //patiencesDataGridView.DataSource = dbm.GetExtPatients();
                reloadData();
                patiencesDataGridView.DataSource = db.ExtPatients.ToList();
            }
        }

        private void patientAddBtn_Click(object sender, EventArgs e)
        {
            using (patientEdit frm = new patientEdit())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string familyName = frm.familyNameTextBox.Text;
                    string name = frm.nameTextBox.Text;
                    string fatherName = frm.fatherNameTextBox.Text;
                    familyName = cutSpacesAndUnprintChars(familyName);
                    name = cutSpacesAndUnprintChars(name);
                    fatherName = cutSpacesAndUnprintChars(fatherName);
                    if (dbm.AddPatient(familyName, name, fatherName, frm.birthDateTimePicker.Value, db.social_status.Where(p => p.soc_status.Equals(frm.socStatusComboBox.SelectedItem.ToString())).First().id, db.current_status.Where(p => p.curr_status.Equals(frm.currStatusComboBox.SelectedItem.ToString())).First().id) == null)
                        MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //patiencesDataGridView.DataSource = db.patients.ToList();
                    //patiencesDataGridView.DataSource = dbm.GetExtPatients();
                    reloadData();
                    patiencesDataGridView.DataSource = db.ExtPatients.ToList();
                }
            }
        }

        private void doctorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(doctorsDataGridView.CurrentRow.Cells[0].Value);
            //7.8
            if (e.ColumnIndex == 7)
            {
                doctor locd = db.doctors.Find(id);
                //Edit
                using (doctorEdit frm = new doctorEdit(locd))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        string familyName = frm.familyNameTextBox.Text;
                        string name = frm.nameTextBox.Text;
                        string fatherName = frm.fatherNameTextBox.Text;
                        familyName = cutSpacesAndUnprintChars(familyName);
                        name = cutSpacesAndUnprintChars(name);
                        fatherName = cutSpacesAndUnprintChars(fatherName);
                        if (dbm.EditDoctor(id, familyName, name, fatherName, db.doctor_position.Where(p => p.position.Equals(frm.posComboBox.SelectedItem.ToString())).First().id, frm.qualifNumericUpDown.Value, frm.notNullCheckBox.Checked))
                        {
                            string spec2 = frm.spec2ComboBox.SelectedItem.ToString();
                            bool nullSpec = frm.notNullSpecCheckBox.Checked;
                            int id2 = db.doctor_specialization.Where(p => p.specialization.Equals(spec2)).FirstOrDefault().id;
                            int did = db.doctors.Where(p => (p.family_name.ToLower().Equals(familyName.ToLower())) && (p.name.ToLower().Equals(name.ToLower())) && (p.father_name.ToLower().Equals(fatherName.ToLower()))).FirstOrDefault().id;
                            if (nullSpec)
                            {
                                if (dbm.AddDoctorNewSpecialization(did, id2))
                                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("Error with Specializations", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //doctorsDataGridView.DataSource = db.doctors.ToList();
                        //doctorsDataGridView.DataSource = dbm.GetExtDoctors();
                        reloadData();
                        doctorsDataGridView.DataSource = db.ExtDoctors.ToList();
                    }
                }
            }
            if (e.ColumnIndex == 8)
            {
                //Delete
                if (dbm.DeleteDoctor(id))
                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //doctorsDataGridView.DataSource = db.doctors.ToList();
                //doctorsDataGridView.DataSource = dbm.GetExtDoctors();
                reloadData();
                doctorsDataGridView.DataSource = db.ExtDoctors.ToList();
            }
        }

        private void doctorShowBtn_Click(object sender, EventArgs e)
        {
            //doctorsDataGridView.DataSource = db.doctors.ToList();
            //doctorsDataGridView.DataSource = dbm.GetExtDoctors();
            reloadData();
            doctorsDataGridView.DataSource = db.ExtDoctors.ToList();
        }

        private void doctorAddBtn_Click(object sender, EventArgs e)
        {
            using (doctorEdit frm = new doctorEdit())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string familyName = frm.familyNameTextBox.Text;
                    string name = frm.nameTextBox.Text;
                    string fatherName = frm.fatherNameTextBox.Text;
                    familyName = cutSpacesAndUnprintChars(familyName);
                    name = cutSpacesAndUnprintChars(name);
                    fatherName = cutSpacesAndUnprintChars(fatherName);
                    if (dbm.AddDoctor(familyName, name, fatherName, db.doctor_position.Where(p => p.position.Equals(frm.posComboBox.SelectedItem.ToString())).First().id, frm.qualifNumericUpDown.Value, frm.notNullCheckBox.Checked) != null)
                    {
                        string spec1 = frm.spec1ComboBox.SelectedItem.ToString();
                        string spec2 = frm.spec2ComboBox.SelectedItem.ToString();
                        bool nullSpec = frm.notNullSpecCheckBox.Checked;
                        int id1 = db.doctor_specialization.Where(p => p.specialization.Equals(spec1)).FirstOrDefault().id;
                        int id2 = db.doctor_specialization.Where(p => p.specialization.Equals(spec2)).FirstOrDefault().id;
                        int did = db.doctors.Where(p => (p.family_name.ToLower().Equals(familyName.ToLower())) && (p.name.ToLower().Equals(name.ToLower())) && (p.father_name.ToLower().Equals(fatherName.ToLower()))).FirstOrDefault().id;
                        if (!dbm.AddDoctorSpecialization(did, id1, id2, nullSpec))
                            MessageBox.Show("Error with Specializtions", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //doctorsDataGridView.DataSource = db.doctors.ToList();
                    //doctorsDataGridView.DataSource = dbm.GetExtDoctors();
                    reloadData();
                    doctorsDataGridView.DataSource = db.ExtDoctors.ToList();
                }
            }
        }

        private void resultShowBtn_Click(object sender, EventArgs e)
        {
            //resultDataGridView.DataSource = db.results.ToList();
            //resultDataGridView.DataSource = dbm.GetExtResults();
            reloadData();
            resultDataGridView.DataSource = db.ExtResults.ToList();
        }

        private void resultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(resultDataGridView.CurrentRow.Cells[0].Value);
            //14.15
            if (e.ColumnIndex == 14)
            {
                //Edit
                result locr = db.results.Find(id);
                using (resultEdit frm = new resultEdit(locr))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        //patient p = db.patients.Where(p1 => (p1.family_name == frm.patientFamilyNameTextBox.Text) && (p1.name == frm.patientNameTextBox.Text) && (p1.father_name == frm.patientFatherNameTextBox.Text)).FirstOrDefault();
                        string locPatient = frm.patientComboBox.SelectedItem.ToString();
                        char sp = ' ';
                        int pos = locPatient.IndexOf(sp);
                        string locPatientFamily = locPatient.Substring(0, pos);
                        string locPatientName = locPatient.Substring(pos + 1);
                        locPatient = locPatientName;
                        pos = locPatient.IndexOf(sp);
                        locPatientName = locPatient.Substring(0, pos);
                        string locPatientFather = locPatient.Substring(pos + 1);
                        patient p = db.patients.Where(p1 => (p1.family_name == locPatientFamily) && (p1.name == locPatientName) && (p1.father_name == locPatientFather)).FirstOrDefault();
                        //doctor d = db.doctors.Where(d1 => (d1.family_name == frm.doctorFamilyNameTextBox.Text) && (d1.name == frm.doctorNameTextBox.Text) && (d1.father_name == frm.doctorFatherNameTextBox.Text)).FirstOrDefault();
                        string locDoctor = frm.doctorComboBox.SelectedItem.ToString();
                        pos = locDoctor.IndexOf(sp);
                        string locDoctorFamily = locDoctor.Substring(0, pos);
                        string locDoctorName = locDoctor.Substring(pos + 1);
                        locDoctor = locDoctorName;
                        pos = locDoctor.IndexOf(sp);
                        locDoctorName = locDoctor.Substring(0, pos);
                        string locDoctorFather = locDoctor.Substring(pos + 1);
                        doctor d = db.doctors.Where(d1 => (d1.family_name == locDoctorFamily) && (d1.name == locDoctorName) && (d1.father_name == locDoctorFather)).FirstOrDefault();
                        string diag = frm.diagnosisTextBox.Text;
                        diag = diagnosisCutSpacesAndUnprintChars(diag);
                        if (dbm.EditResult(id, p.id, d.id, diag, frm.outpatientCheckBox.Checked, Convert.ToInt32(frm.countDaysTextBox.Text), frm.clinicalAccountCheckBox.Checked, frm.startDateTimePicker.Value, frm.predictedDateTimePicker.Value, frm.factDateTimePicker.Value, frm.notNullCheckBox.Checked))
                            MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //resultDataGridView.DataSource = db.results.ToList();
                        //resultDataGridView.DataSource = dbm.GetExtResults();
                        reloadData();
                        resultDataGridView.DataSource = db.ExtResults.ToList();
                    }
                }
            }
            if (e.ColumnIndex == 15)
            {
                //Delete
                if (dbm.DeleteResult(id))
                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //resultDataGridView.DataSource = db.results.ToList();
                //resultDataGridView.DataSource = dbm.GetExtResults();
                reloadData();
                resultDataGridView.DataSource = db.ExtResults.ToList();
            }
        }

        private void resultAddBtn_Click(object sender, EventArgs e)
        {
            using (resultEdit frm = new resultEdit())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //patient p = db.patients.Where(p1 => (p1.family_name == frm.patientFamilyNameTextBox.Text) && (p1.name == frm.patientNameTextBox.Text) && (p1.father_name == frm.patientFatherNameTextBox.Text)).FirstOrDefault();
                    string locPatient = frm.patientComboBox.SelectedItem.ToString();
                    char sp = ' ';
                    int pos = locPatient.IndexOf(sp);
                    string locPatientFamily = locPatient.Substring(0, pos);
                    string locPatientName = locPatient.Substring(pos + 1);
                    locPatient = locPatientName;
                    pos = locPatient.IndexOf(sp);
                    locPatientName = locPatient.Substring(0, pos);
                    string locPatientFather = locPatient.Substring(pos + 1);
                    patient p = db.patients.Where(p1 => (p1.family_name == locPatientFamily) && (p1.name == locPatientName) && (p1.father_name == locPatientFather)).FirstOrDefault();
                    //doctor d = db.doctors.Where(d1 => (d1.family_name == frm.doctorFamilyNameTextBox.Text) && (d1.name == frm.doctorNameTextBox.Text) && (d1.father_name == frm.doctorFatherNameTextBox.Text)).FirstOrDefault();
                    string locDoctor = frm.doctorComboBox.SelectedItem.ToString();
                    pos = locDoctor.IndexOf(sp);
                    string locDoctorFamily = locDoctor.Substring(0, pos);
                    string locDoctorName = locDoctor.Substring(pos + 1);
                    locDoctor = locDoctorName;
                    pos = locDoctor.IndexOf(sp);
                    locDoctorName = locDoctor.Substring(0, pos);
                    string locDoctorFather = locDoctor.Substring(pos + 1);
                    doctor d = db.doctors.Where(d1 => (d1.family_name == locDoctorFamily) && (d1.name == locDoctorName) && (d1.father_name == locDoctorFather)).FirstOrDefault();
                    string diag = frm.diagnosisTextBox.Text;
                    diag = diagnosisCutSpacesAndUnprintChars(diag);
                    if (dbm.AddResult(p.id, d.id, diag, frm.outpatientCheckBox.Checked, Convert.ToInt32(frm.countDaysTextBox.Text), frm.clinicalAccountCheckBox.Checked, frm.startDateTimePicker.Value, frm.predictedDateTimePicker.Value, frm.factDateTimePicker.Value, frm.notNullCheckBox.Checked) == null)
                        MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //resultDataGridView.DataSource = db.results.ToList();
                    //resultDataGridView.DataSource = dbm.GetExtResults();
                    reloadData();
                    resultDataGridView.DataSource = db.ExtResults.ToList();
                }
            }
        }
    }
}
