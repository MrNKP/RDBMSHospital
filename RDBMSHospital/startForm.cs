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
            patient locp = db.patients.Find(id);
            //7.8
            if (e.ColumnIndex == 7) //MessageBox.Show("Edit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            {
                using (patientEdit frm = new patientEdit(locp))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        //Edit
                        /*
                        locp.family_name = frm.familyNameTextBox.Text;
                        locp.name = frm.nameTextBox.Text;
                        locp.father_name = frm.fatherNameTextBox.Text;
                        locp.bitrh = Convert.ToDateTime(frm.birthTextBox.Text);
                        //List<social_status> lsst = db.social_status.ToList();
                        //locp.soc_status = lsst.Find(p => p.soc_status.Equals(frm.socStatusTextBox.Text)).id;
                        locp.social_status = db.social_status.Where(p => p.soc_status.Equals(frm.socStatusTextBox.Text)).First();
                        locp.soc_status = locp.social_status.id;
                        locp.current_status = db.current_status.Where(p => p.curr_status.Equals(frm.currStatusTextBox.Text)).First();
                        locp.cur_status = locp.current_status.id;
                        db.SaveChanges();
                        */
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
    }
}
