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
        //string familyName, name, fatherName;
        //DateTime birth;
        //string socSt, currSt;
        patient p;
        public patientEdit()
        {
            InitializeComponent();
        }
        public patientEdit(patient np)
        {
            InitializeComponent();
            p = np;
            familyNameTextBox.Text = p.family_name;
            nameTextBox.Text = p.name;
            fatherNameTextBox.Text = p.father_name;
            birthTextBox.Text = Convert.ToString(p.bitrh);
            socStatusTextBox.Text = p.social_status.soc_status;
            currStatusTextBox.Text = p.current_status.curr_status;
        }
    }
}
