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
            this.family_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.father_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitrh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soc_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cur_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditPatient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeletePatient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.doctorsTab = new System.Windows.Forms.TabPage();
            this.doctorAddBtn = new System.Windows.Forms.Button();
            this.doctorShowBtn = new System.Windows.Forms.Button();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditDoctor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteDoctor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.resultsTab = new System.Windows.Forms.TabPage();
            this.resultAddBtn = new System.Windows.Forms.Button();
            this.resultShowBtn = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.resultEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.resultDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outpatienttreatmentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.countwithoutworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicalaccountDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socialstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseTabControl.SuspendLayout();
            this.patientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patiencesDataGridView)).BeginInit();
            this.doctorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            this.resultsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
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
            this.EditPatient,
            this.DeletePatient});
            this.patiencesDataGridView.DataSource = this.patientBindingSource;
            this.patiencesDataGridView.Location = new System.Drawing.Point(7, 7);
            this.patiencesDataGridView.Name = "patiencesDataGridView";
            this.patiencesDataGridView.RowTemplate.Height = 24;
            this.patiencesDataGridView.Size = new System.Drawing.Size(1155, 426);
            this.patiencesDataGridView.TabIndex = 0;
            this.patiencesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patiencesDataGridView_CellContentClick);
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
            // EditPatient
            // 
            this.EditPatient.HeaderText = "";
            this.EditPatient.Name = "EditPatient";
            this.EditPatient.Text = "Edit";
            this.EditPatient.UseColumnTextForButtonValue = true;
            // 
            // DeletePatient
            // 
            this.DeletePatient.HeaderText = "";
            this.DeletePatient.Name = "DeletePatient";
            this.DeletePatient.Text = "Delete";
            this.DeletePatient.UseColumnTextForButtonValue = true;
            // 
            // doctorsTab
            // 
            this.doctorsTab.Controls.Add(this.doctorAddBtn);
            this.doctorsTab.Controls.Add(this.doctorShowBtn);
            this.doctorsTab.Controls.Add(this.doctorsDataGridView);
            this.doctorsTab.Location = new System.Drawing.Point(4, 25);
            this.doctorsTab.Name = "doctorsTab";
            this.doctorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.doctorsTab.Size = new System.Drawing.Size(1356, 439);
            this.doctorsTab.TabIndex = 1;
            this.doctorsTab.Text = "Doctors";
            this.doctorsTab.UseVisualStyleBackColor = true;
            // 
            // doctorAddBtn
            // 
            this.doctorAddBtn.Location = new System.Drawing.Point(1167, 68);
            this.doctorAddBtn.Name = "doctorAddBtn";
            this.doctorAddBtn.Size = new System.Drawing.Size(182, 56);
            this.doctorAddBtn.TabIndex = 2;
            this.doctorAddBtn.Text = "Add";
            this.doctorAddBtn.UseVisualStyleBackColor = true;
            this.doctorAddBtn.Click += new System.EventHandler(this.doctorAddBtn_Click);
            // 
            // doctorShowBtn
            // 
            this.doctorShowBtn.Location = new System.Drawing.Point(1168, 6);
            this.doctorShowBtn.Name = "doctorShowBtn";
            this.doctorShowBtn.Size = new System.Drawing.Size(182, 56);
            this.doctorShowBtn.TabIndex = 1;
            this.doctorShowBtn.Text = "Show";
            this.doctorShowBtn.UseVisualStyleBackColor = true;
            this.doctorShowBtn.Click += new System.EventHandler(this.doctorShowBtn_Click);
            // 
            // doctorsDataGridView
            // 
            this.doctorsDataGridView.AutoGenerateColumns = false;
            this.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.position,
            this.qualification,
            this.EditDoctor,
            this.DeleteDoctor});
            this.doctorsDataGridView.DataSource = this.doctorBindingSource;
            this.doctorsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.RowTemplate.Height = 24;
            this.doctorsDataGridView.Size = new System.Drawing.Size(1155, 426);
            this.doctorsDataGridView.TabIndex = 0;
            this.doctorsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "family_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "family_name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "father_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "father_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "position";
            this.position.Name = "position";
            // 
            // qualification
            // 
            this.qualification.DataPropertyName = "qualification";
            this.qualification.HeaderText = "qualification";
            this.qualification.Name = "qualification";
            // 
            // EditDoctor
            // 
            this.EditDoctor.HeaderText = "";
            this.EditDoctor.Name = "EditDoctor";
            this.EditDoctor.Text = "Edit";
            this.EditDoctor.UseColumnTextForButtonValue = true;
            // 
            // DeleteDoctor
            // 
            this.DeleteDoctor.HeaderText = "";
            this.DeleteDoctor.Name = "DeleteDoctor";
            this.DeleteDoctor.Text = "Delete";
            this.DeleteDoctor.UseColumnTextForButtonValue = true;
            // 
            // resultsTab
            // 
            this.resultsTab.Controls.Add(this.resultAddBtn);
            this.resultsTab.Controls.Add(this.resultShowBtn);
            this.resultsTab.Controls.Add(this.resultDataGridView);
            this.resultsTab.Location = new System.Drawing.Point(4, 25);
            this.resultsTab.Name = "resultsTab";
            this.resultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTab.Size = new System.Drawing.Size(1356, 439);
            this.resultsTab.TabIndex = 2;
            this.resultsTab.Text = "Results";
            this.resultsTab.UseVisualStyleBackColor = true;
            // 
            // resultAddBtn
            // 
            this.resultAddBtn.Location = new System.Drawing.Point(1168, 68);
            this.resultAddBtn.Name = "resultAddBtn";
            this.resultAddBtn.Size = new System.Drawing.Size(182, 56);
            this.resultAddBtn.TabIndex = 2;
            this.resultAddBtn.Text = "Add";
            this.resultAddBtn.UseVisualStyleBackColor = true;
            this.resultAddBtn.Click += new System.EventHandler(this.resultAddBtn_Click);
            // 
            // resultShowBtn
            // 
            this.resultShowBtn.Location = new System.Drawing.Point(1168, 6);
            this.resultShowBtn.Name = "resultShowBtn";
            this.resultShowBtn.Size = new System.Drawing.Size(182, 56);
            this.resultShowBtn.TabIndex = 1;
            this.resultShowBtn.Text = "Show";
            this.resultShowBtn.UseVisualStyleBackColor = true;
            this.resultShowBtn.Click += new System.EventHandler(this.resultShowBtn_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AutoGenerateColumns = false;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.patientIdDataGridViewTextBoxColumn,
            this.doctorIdDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.outpatienttreatmentDataGridViewCheckBoxColumn,
            this.countwithoutworkDataGridViewTextBoxColumn,
            this.clinicalaccountDataGridViewCheckBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.predictedDataGridViewTextBoxColumn,
            this.factDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.resultEdit,
            this.resultDelete});
            this.resultDataGridView.DataSource = this.resultBindingSource;
            this.resultDataGridView.Location = new System.Drawing.Point(6, 3);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowTemplate.Height = 24;
            this.resultDataGridView.Size = new System.Drawing.Size(1156, 426);
            this.resultDataGridView.TabIndex = 0;
            this.resultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDataGridView_CellContentClick);
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
            // resultEdit
            // 
            this.resultEdit.HeaderText = "";
            this.resultEdit.Name = "resultEdit";
            this.resultEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resultEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.resultEdit.Text = "Edit";
            this.resultEdit.UseColumnTextForButtonValue = true;
            // 
            // resultDelete
            // 
            this.resultDelete.HeaderText = "";
            this.resultDelete.Name = "resultDelete";
            this.resultDelete.Text = "Delete";
            this.resultDelete.UseColumnTextForButtonValue = true;
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
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(RDBMSHospital.doctor);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "patientId";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "patientId";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            // 
            // doctorIdDataGridViewTextBoxColumn
            // 
            this.doctorIdDataGridViewTextBoxColumn.DataPropertyName = "doctorId";
            this.doctorIdDataGridViewTextBoxColumn.HeaderText = "doctorId";
            this.doctorIdDataGridViewTextBoxColumn.Name = "doctorIdDataGridViewTextBoxColumn";
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            // 
            // outpatienttreatmentDataGridViewCheckBoxColumn
            // 
            this.outpatienttreatmentDataGridViewCheckBoxColumn.DataPropertyName = "outpatient_treatment";
            this.outpatienttreatmentDataGridViewCheckBoxColumn.HeaderText = "outpatient_treatment";
            this.outpatienttreatmentDataGridViewCheckBoxColumn.Name = "outpatienttreatmentDataGridViewCheckBoxColumn";
            // 
            // countwithoutworkDataGridViewTextBoxColumn
            // 
            this.countwithoutworkDataGridViewTextBoxColumn.DataPropertyName = "count_without_work";
            this.countwithoutworkDataGridViewTextBoxColumn.HeaderText = "count_without_work";
            this.countwithoutworkDataGridViewTextBoxColumn.Name = "countwithoutworkDataGridViewTextBoxColumn";
            // 
            // clinicalaccountDataGridViewCheckBoxColumn
            // 
            this.clinicalaccountDataGridViewCheckBoxColumn.DataPropertyName = "clinical_account";
            this.clinicalaccountDataGridViewCheckBoxColumn.HeaderText = "clinical_account";
            this.clinicalaccountDataGridViewCheckBoxColumn.Name = "clinicalaccountDataGridViewCheckBoxColumn";
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            // 
            // predictedDataGridViewTextBoxColumn
            // 
            this.predictedDataGridViewTextBoxColumn.DataPropertyName = "predicted";
            this.predictedDataGridViewTextBoxColumn.HeaderText = "predicted";
            this.predictedDataGridViewTextBoxColumn.Name = "predictedDataGridViewTextBoxColumn";
            // 
            // factDataGridViewTextBoxColumn
            // 
            this.factDataGridViewTextBoxColumn.DataPropertyName = "fact";
            this.factDataGridViewTextBoxColumn.HeaderText = "fact";
            this.factDataGridViewTextBoxColumn.Name = "factDataGridViewTextBoxColumn";
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "patient";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.Visible = false;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataSource = typeof(RDBMSHospital.result);
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
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            this.resultsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialstatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dataBaseTabControl;
        private System.Windows.Forms.TabPage patientsTab;
        private System.Windows.Forms.DataGridView patiencesDataGridView;
        private System.Windows.Forms.TabPage doctorsTab;
        private System.Windows.Forms.TabPage resultsTab;
        private System.Windows.Forms.DataGridView doctorsDataGridView;
        private System.Windows.Forms.Button patientAddBtn;
        private System.Windows.Forms.Button patientShowBtn;
        private System.Windows.Forms.Button doctorAddBtn;
        private System.Windows.Forms.Button doctorShowBtn;
        private System.Windows.Forms.Button resultAddBtn;
        private System.Windows.Forms.Button resultShowBtn;
        private System.Windows.Forms.DataGridView resultDataGridView;
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
        private System.Windows.Forms.DataGridViewButtonColumn EditPatient;
        private System.Windows.Forms.DataGridViewButtonColumn DeletePatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualification;
        private System.Windows.Forms.DataGridViewButtonColumn EditDoctor;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteDoctor;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn outpatienttreatmentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countwithoutworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clinicalaccountDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predictedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn resultEdit;
        private System.Windows.Forms.DataGridViewButtonColumn resultDelete;
    }
}

