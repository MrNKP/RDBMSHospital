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
    public partial class patientEdit : Form
    {
        patient p;
        HospitalContext db = new HospitalContext();
        public patientEdit()
        {
            InitializeComponent();
            List<string> socS = new List<string>();
            for (int i = 0; i < db.social_status.ToList().Count; i++) socS.Add(db.social_status.ToList()[i].soc_status);
            socStatusComboBox.DataSource = socS;
            List<string> curS = new List<string>();
            for (int i = 0; i < db.current_status.ToList().Count; i++) curS.Add(db.current_status.ToList()[i].curr_status);
            currStatusComboBox.DataSource = curS;
            birthDateTimePicker.MaxDate = DateTime.Now;
        }
        public patientEdit(patient np)
        {
            InitializeComponent();
            p = np;
            familyNameTextBox.Text = p.family_name;
            nameTextBox.Text = p.name;
            fatherNameTextBox.Text = p.father_name;
            //birthTextBox.Text = Convert.ToString(p.bitrh);
            birthDateTimePicker.MaxDate = DateTime.Now;
            birthDateTimePicker.Value = p.bitrh;
            //socStatusTextBox.Text = p.social_status.soc_status;
            //currStatusTextBox.Text = p.current_status.curr_status;
            List<string> socS = new List<string>();
            for (int i = 0; i < db.social_status.ToList().Count; i++) socS.Add(db.social_status.ToList()[i].soc_status);
            socStatusComboBox.DataSource = socS;
            socStatusComboBox.SelectedItem = p.social_status.soc_status;
            List<string> curS = new List<string>();
            for (int i = 0; i < db.current_status.ToList().Count; i++) curS.Add(db.current_status.ToList()[i].curr_status);
            currStatusComboBox.DataSource = curS;
            currStatusComboBox.SelectedItem = p.current_status.curr_status;
        }
    }
}
