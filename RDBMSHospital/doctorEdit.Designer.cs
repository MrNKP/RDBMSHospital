namespace RDBMSHospital
{
    partial class doctorEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctorEdit));
            this.familyNameLbl = new System.Windows.Forms.Label();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.qualifTextBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.fatherNameLbl = new System.Windows.Forms.Label();
            this.posLbl = new System.Windows.Forms.Label();
            this.qualifLbl = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.posComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // familyNameLbl
            // 
            this.familyNameLbl.AutoSize = true;
            this.familyNameLbl.Location = new System.Drawing.Point(12, 9);
            this.familyNameLbl.Name = "familyNameLbl";
            this.familyNameLbl.Size = new System.Drawing.Size(101, 17);
            this.familyNameLbl.TabIndex = 0;
            this.familyNameLbl.Text = "Family Name : ";
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.Location = new System.Drawing.Point(125, 6);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(352, 22);
            this.familyNameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(125, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(352, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(125, 62);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(352, 22);
            this.fatherNameTextBox.TabIndex = 3;
            // 
            // qualifTextBox
            // 
            this.qualifTextBox.Location = new System.Drawing.Point(125, 118);
            this.qualifTextBox.Name = "qualifTextBox";
            this.qualifTextBox.Size = new System.Drawing.Size(352, 22);
            this.qualifTextBox.TabIndex = 5;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 37);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(57, 17);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Name : ";
            // 
            // fatherNameLbl
            // 
            this.fatherNameLbl.AutoSize = true;
            this.fatherNameLbl.Location = new System.Drawing.Point(12, 65);
            this.fatherNameLbl.Name = "fatherNameLbl";
            this.fatherNameLbl.Size = new System.Drawing.Size(102, 17);
            this.fatherNameLbl.TabIndex = 7;
            this.fatherNameLbl.Text = "Father Name : ";
            // 
            // posLbl
            // 
            this.posLbl.AutoSize = true;
            this.posLbl.Location = new System.Drawing.Point(12, 93);
            this.posLbl.Name = "posLbl";
            this.posLbl.Size = new System.Drawing.Size(70, 17);
            this.posLbl.TabIndex = 8;
            this.posLbl.Text = "Position : ";
            // 
            // qualifLbl
            // 
            this.qualifLbl.AutoSize = true;
            this.qualifLbl.Location = new System.Drawing.Point(12, 121);
            this.qualifLbl.Name = "qualifLbl";
            this.qualifLbl.Size = new System.Drawing.Size(98, 17);
            this.qualifLbl.TabIndex = 9;
            this.qualifLbl.Text = "Qualification : ";
            // 
            // acceptBtn
            // 
            this.acceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptBtn.Location = new System.Drawing.Point(8, 146);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(469, 51);
            this.acceptBtn.TabIndex = 6;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(8, 203);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(469, 51);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // posComboBox
            // 
            this.posComboBox.FormattingEnabled = true;
            this.posComboBox.Location = new System.Drawing.Point(125, 90);
            this.posComboBox.Name = "posComboBox";
            this.posComboBox.Size = new System.Drawing.Size(352, 24);
            this.posComboBox.TabIndex = 4;
            // 
            // doctorEdit
            // 
            this.AcceptButton = this.acceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(483, 264);
            this.ControlBox = false;
            this.Controls.Add(this.posComboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.qualifLbl);
            this.Controls.Add(this.posLbl);
            this.Controls.Add(this.fatherNameLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.qualifTextBox);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(this.familyNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "doctorEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label familyNameLbl;
        public System.Windows.Forms.TextBox familyNameTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox fatherNameTextBox;
        public System.Windows.Forms.TextBox qualifTextBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label fatherNameLbl;
        private System.Windows.Forms.Label posLbl;
        private System.Windows.Forms.Label qualifLbl;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.ComboBox posComboBox;
    }
}