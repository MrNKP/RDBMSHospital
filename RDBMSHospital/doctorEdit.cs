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
    public partial class doctorEdit : Form
    {
        doctor d;
        HospitalContext db = new HospitalContext();
        public doctorEdit()
        {
            InitializeComponent();
            List<string> docPos = new List<string>();
            for (int i = 0; i < db.doctor_position.ToList().Count; i++) docPos.Add(db.doctor_position.ToList()[i].position);
            posComboBox.DataSource = docPos;
        }
        public doctorEdit(doctor nd)
        {
            InitializeComponent();
            d = nd;
            familyNameTextBox.Text = d.family_name;
            nameTextBox.Text = d.name;
            fatherNameTextBox.Text = d.father_name;
            //posTextBox.Text = d.doctor_position.position;
            List<string> docPos = new List<string>();
            for (int i = 0; i < db.doctor_position.ToList().Count; i++) docPos.Add(db.doctor_position.ToList()[i].position);
            posComboBox.DataSource = docPos;
            posComboBox.SelectedItem = d.doctor_position.position;
            qualifTextBox.Text = Convert.ToString(d.qualification);
        }
    }
}
