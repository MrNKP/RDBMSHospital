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
        doctor d = null;
        bool en = false;
        HospitalContext db = new HospitalContext();
        public doctorEdit()
        {
            InitializeComponent();
            List<string> specs = new List<string>();
            foreach (var item in db.doctor_specialization)
                specs.Add(item.specialization);
            List<string> docPos = new List<string>();
            for (int i = 0; i < db.doctor_position.ToList().Count; i++) docPos.Add(db.doctor_position.ToList()[i].position);
            posComboBox.DataSource = docPos;
            qualifNumericUpDown.Enabled = notNullCheckBox.Checked;
            spec2ComboBox.Enabled = notNullSpecCheckBox.Checked;
            spec1ComboBox.BindingContext = new BindingContext();
            spec1ComboBox.DataSource = specs;
            spec2ComboBox.BindingContext = new BindingContext();
            spec2ComboBox.DataSource = specs;
        }
        public doctorEdit(doctor nd)
        {
            InitializeComponent();
            d = nd;
            familyNameTextBox.Text = d.family_name;
            nameTextBox.Text = d.name;
            fatherNameTextBox.Text = d.father_name;
            //posTextBox.Text = d.doctor_position.position;
            List<string> specs = new List<string>();
            foreach (var item in db.doctor_specialization)
                specs.Add(item.specialization);
            spec1ComboBox.BindingContext = new BindingContext();
            spec1ComboBox.DataSource = specs;
            spec2ComboBox.BindingContext = new BindingContext();
            spec2ComboBox.DataSource = specs;
            spec1ComboBox.Enabled = false;
            spec2ComboBox.Enabled = false;
            List<string> docPos = new List<string>();
            for (int i = 0; i < db.doctor_position.ToList().Count; i++) docPos.Add(db.doctor_position.ToList()[i].position);
            posComboBox.DataSource = docPos;
            posComboBox.SelectedItem = d.doctor_position.position;
            //qualifTextBox.Text = Convert.ToString(d.qualification);
            qualifNumericUpDown.Enabled = notNullCheckBox.Checked;
            //spec2ComboBox.Enabled = notNullSpecCheckBox.Checked;
            if (nd.qualification != null)
            {
                notNullCheckBox.Checked = true;
                qualifNumericUpDown.Enabled = true;
                qualifNumericUpDown.Value = Convert.ToDecimal(nd.qualification);
            }
            else
            {
                notNullCheckBox.Checked = false;
                qualifNumericUpDown.Enabled = false;
            }
            List<doctor_to_specialization> dspecs = db.doctor_to_specialization.Where(p => p.docID == d.id).ToList();
            spec1ComboBox.SelectedItem = dspecs[0].doctor_specialization.specialization;     
            if (dspecs.Count == 2)
                spec2ComboBox.SelectedItem = dspecs[1].doctor_specialization.specialization;
            en = (d == null) || (dspecs.Count != 2);
        }

        private void notNullCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (notNullCheckBox.Checked)
                qualifNumericUpDown.Enabled = true;
            else
            */
            qualifNumericUpDown.Enabled = notNullCheckBox.Checked;
        }

        private void notNullSpecCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (en)
                spec2ComboBox.Enabled = notNullSpecCheckBox.Checked;
        }
    }
}
