namespace RDBMSHospital
{
    partial class startForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.dataBaseTabControl = new System.Windows.Forms.TabControl();
            this.patientsTab = new System.Windows.Forms.TabPage();
            this.patientAddBtn = new System.Windows.Forms.Button();
            this.patientShowBtn = new System.Windows.Forms.Button();
            this.patiencesDataGridView = new System.Windows.Forms.DataGridView();
            this.doctorsTab = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.resultsTab = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.family_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.father_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitrh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soc_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cur_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socialstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseTabControl.SuspendLayout();
            this.patientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patiencesDataGridView)).BeginInit();
            this.doctorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.resultsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBaseTabControl
            // 
            this.dataBaseTabControl.Controls.Add(this.patientsTab);
            this.dataBaseTabControl.Controls.Add(this.doctorsTab);
            this.dataBaseTabControl.Controls.Add(this.resultsTab);
            this.dataBaseTabControl.Location = new System.Drawing.Point(12, 12);
            this.dataBaseTabControl.Name = "dataBaseTabControl";
            this.dataBaseTabControl.SelectedIndex = 0;
            this.dataBaseTabControl.Size = new System.Drawing.Size(1364, 468);
            this.dataBaseTabControl.TabIndex = 0;
            // 
            // patientsTab
            // 
            this.patientsTab.Controls.Add(this.patientAddBtn);
            this.patientsTab.Controls.Add(this.patientShowBtn);
            this.patientsTab.Controls.Add(this.patiencesDataGridView);
            this.patientsTab.Location = new System.Drawing.Point(4, 25);
            this.patientsTab.Name = "patientsTab";
            this.patientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.patientsTab.Size = new System.Drawing.Size(1356, 439);
            this.patientsTab.TabIndex = 0;
            this.patientsTab.Text = "Patiences";
            this.patientsTab.UseVisualStyleBackColor = true;
            // 
            // patientAddBtn
            // 
            this.patientAddBtn.Location = new System.Drawing.Point(1167, 69);
            this.patientAddBtn.Name = "patientAddBtn";
            this.patientAddBtn.Size = new System.Drawing.Size(182, 56);
            this.patientAddBtn.TabIndex = 2;
            this.patientAddBtn.Text = "Add";
            this.patientAddBtn.UseVisualStyleBackColor = true;
            this.patientAddBtn.Click += new System.EventHandler(this.patientAddBtn_Click);
            // 
            // patientShowBtn
            // 
            this.patientShowBtn.Location = new System.Drawing.Point(1168, 7);
            this.patientShowBtn.Name = "patientShowBtn";
            this.patientShowBtn.Size = new System.Drawing.Size(182, 56);
            this.patientShowBtn.TabIndex = 1;
            this.patientShowBtn.Text = "Show";
            this.patientShowBtn.UseVisualStyleBackColor = true;
            this.patientShowBtn.Click += new System.EventHandler(this.patientShowBtn_Click);
            // 
            // patiencesDataGridView
            // 
            this.patiencesDataGridView.AutoGenerateColumns = false;
            this.patiencesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patiencesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.family_name,
            this.name,
            this.father_name,
            this.bitrh,
            this.soc_status,
            this.cur_status,
            this.Edit,
            this.Delete});
            this.patiencesDataGridView.DataSource = this.patientBindingSource;
            this.patiencesDataGridView.Location = new System.Drawing.Point(7, 7);
            this.patiencesDataGridView.Name = "patiencesDataGridView";
            this.patiencesDataGridView.RowTemplate.Height = 24;
            this.patiencesDataGridView.Size = new System.Drawing.Size(1155, 426);
            this.patiencesDataGridView.TabIndex = 0;
            this.patiencesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patiencesDataGridView_CellContentClick);
            // 
            // doctorsTab
            // 
            this.doctorsTab.Controls.Add(this.button4);
            this.doctorsTab.Controls.Add(this.button3);
            this.doctorsTab.Controls.Add(this.dataGridView2);
            this.doctorsTab.Location = new System.Drawing.Point(4, 25);
            this.doctorsTab.Name = "doctorsTab";
            this.doctorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.doctorsTab.Size = new System.Drawing.Size(1356, 439);
            this.doctorsTab.TabIndex = 1;
            this.doctorsTab.Text = "Doctors";
            this.doctorsTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1167, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 56);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1168, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 56);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1155, 426);
            this.dataGridView2.TabIndex = 0;
            // 
            // resultsTab
            // 
            this.resultsTab.Controls.Add(this.button6);
            this.resultsTab.Controls.Add(this.button5);
            this.resultsTab.Controls.Add(this.dataGridView3);
            this.resultsTab.Location = new System.Drawing.Point(4, 25);
            this.resultsTab.Name = "resultsTab";
            this.resultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTab.Size = new System.Drawing.Size(1356, 439);
            this.resultsTab.TabIndex = 2;
            this.resultsTab.Text = "Results";
            this.resultsTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1168, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 56);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1168, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 56);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1156, 426);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.DataPropertyName = "social_status";
            this.dataGridViewLinkColumn1.HeaderText = "social_status";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.DataPropertyName = "current_status";
            this.dataGridViewLinkColumn2.HeaderText = "current_status";
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            // 
            // family_name
            // 
            this.family_name.DataPropertyName = "family_name";
            this.family_name.HeaderText = "family_name";
            this.family_name.Name = "family_name";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // father_name
            // 
            this.father_name.DataPropertyName = "father_name";
            this.father_name.HeaderText = "father_name";
            this.father_name.Name = "father_name";
            // 
            // bitrh
            // 
            this.bitrh.DataPropertyName = "bitrh";
            this.bitrh.HeaderText = "bitrh";
            this.bitrh.Name = "bitrh";
            // 
            // soc_status
            // 
            this.soc_status.DataPropertyName = "soc_status";
            this.soc_status.HeaderText = "soc_status";
            this.soc_status.Name = "soc_status";
            this.soc_status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cur_status
            // 
            this.cur_status.DataPropertyName = "cur_status";
            this.cur_status.HeaderText = "cur_status";
            this.cur_status.Name = "cur_status";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(RDBMSHospital.patient);
            // 
            // socialstatusBindingSource
            // 
            this.socialstatusBindingSource.DataSource = typeof(RDBMSHospital.social_status);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 492);
            this.Controls.Add(this.dataBaseTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View DataBase";
            this.dataBaseTabControl.ResumeLayout(false);
            this.patientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patiencesDataGridView)).EndInit();
            this.doctorsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.resultsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dataBaseTabControl;
        private System.Windows.Forms.TabPage patientsTab;
        private System.Windows.Forms.DataGridView patiencesDataGridView;
        private System.Windows.Forms.TabPage doctorsTab;
        private System.Windows.Forms.TabPage resultsTab;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button patientAddBtn;
        private System.Windows.Forms.Button patientShowBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource socialstatusBindingSource;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn family_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn father_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitrh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soc_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cur_status;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

