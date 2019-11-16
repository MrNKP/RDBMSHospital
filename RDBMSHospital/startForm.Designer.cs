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
            this.doctorAddBtn = new System.Windows.Forms.Button();
            this.doctorShowBtn = new System.Windows.Forms.Button();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.resultsTab = new System.Windows.Forms.TabPage();
            this.resultAddBtn = new System.Windows.Forms.Button();
            this.resultShowBtn = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.extPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitrhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditPatient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeletePatient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.extDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditDoctor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteDoctor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.extResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathernameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outpatienttreatmentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.countwithoutworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicalaccountDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.resultDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataBaseTabControl.SuspendLayout();
            this.patientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patiencesDataGridView)).BeginInit();
            this.doctorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            this.resultsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extDoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extResultBindingSource)).BeginInit();
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
            this.familynameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fathernameDataGridViewTextBoxColumn,
            this.bitrhDataGridViewTextBoxColumn,
            this.socstatusDataGridViewTextBoxColumn,
            this.currstatusDataGridViewTextBoxColumn,
            this.EditPatient,
            this.DeletePatient});
            this.patiencesDataGridView.DataSource = this.extPatientBindingSource;
            this.patiencesDataGridView.Location = new System.Drawing.Point(7, 7);
            this.patiencesDataGridView.Name = "patiencesDataGridView";
            this.patiencesDataGridView.ReadOnly = true;
            this.patiencesDataGridView.RowTemplate.Height = 24;
            this.patiencesDataGridView.Size = new System.Drawing.Size(1155, 426);
            this.patiencesDataGridView.TabIndex = 0;
            this.patiencesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patiencesDataGridView_CellContentClick);
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
            this.familynameDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.fathernameDataGridViewTextBoxColumn1,
            this.positionDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn,
            this.EditDoctor,
            this.DeleteDoctor});
            this.doctorsDataGridView.DataSource = this.extDoctorBindingSource;
            this.doctorsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.ReadOnly = true;
            this.doctorsDataGridView.RowTemplate.Height = 24;
            this.doctorsDataGridView.Size = new System.Drawing.Size(1155, 426);
            this.doctorsDataGridView.TabIndex = 0;
            this.doctorsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorsDataGridView_CellContentClick);
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
            this.familynameDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.fathernameDataGridViewTextBoxColumn2,
            this.expr1DataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.outpatienttreatmentDataGridViewCheckBoxColumn,
            this.countwithoutworkDataGridViewTextBoxColumn,
            this.clinicalaccountDataGridViewCheckBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.predictedDataGridViewTextBoxColumn,
            this.factDataGridViewTextBoxColumn,
            this.resultEdit,
            this.resultDelete});
            this.resultDataGridView.DataSource = this.extResultBindingSource;
            this.resultDataGridView.Location = new System.Drawing.Point(6, 7);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
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
            // extPatientBindingSource
            // 
            this.extPatientBindingSource.DataSource = typeof(RDBMSHospital.ExtPatient);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // familynameDataGridViewTextBoxColumn
            // 
            this.familynameDataGridViewTextBoxColumn.DataPropertyName = "family_name";
            this.familynameDataGridViewTextBoxColumn.HeaderText = "family_name";
            this.familynameDataGridViewTextBoxColumn.Name = "familynameDataGridViewTextBoxColumn";
            this.familynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fathernameDataGridViewTextBoxColumn
            // 
            this.fathernameDataGridViewTextBoxColumn.DataPropertyName = "father_name";
            this.fathernameDataGridViewTextBoxColumn.HeaderText = "father_name";
            this.fathernameDataGridViewTextBoxColumn.Name = "fathernameDataGridViewTextBoxColumn";
            this.fathernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bitrhDataGridViewTextBoxColumn
            // 
            this.bitrhDataGridViewTextBoxColumn.DataPropertyName = "bitrh";
            this.bitrhDataGridViewTextBoxColumn.HeaderText = "bitrh";
            this.bitrhDataGridViewTextBoxColumn.Name = "bitrhDataGridViewTextBoxColumn";
            this.bitrhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // socstatusDataGridViewTextBoxColumn
            // 
            this.socstatusDataGridViewTextBoxColumn.DataPropertyName = "soc_status";
            this.socstatusDataGridViewTextBoxColumn.HeaderText = "soc_status";
            this.socstatusDataGridViewTextBoxColumn.Name = "socstatusDataGridViewTextBoxColumn";
            this.socstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currstatusDataGridViewTextBoxColumn
            // 
            this.currstatusDataGridViewTextBoxColumn.DataPropertyName = "curr_status";
            this.currstatusDataGridViewTextBoxColumn.HeaderText = "curr_status";
            this.currstatusDataGridViewTextBoxColumn.Name = "currstatusDataGridViewTextBoxColumn";
            this.currstatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditPatient
            // 
            this.EditPatient.HeaderText = "";
            this.EditPatient.Name = "EditPatient";
            this.EditPatient.ReadOnly = true;
            this.EditPatient.Text = "Edit";
            this.EditPatient.UseColumnTextForButtonValue = true;
            // 
            // DeletePatient
            // 
            this.DeletePatient.HeaderText = "";
            this.DeletePatient.Name = "DeletePatient";
            this.DeletePatient.ReadOnly = true;
            this.DeletePatient.Text = "Delete";
            this.DeletePatient.UseColumnTextForButtonValue = true;
            // 
            // extDoctorBindingSource
            // 
            this.extDoctorBindingSource.DataSource = typeof(RDBMSHospital.ExtDoctor);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // familynameDataGridViewTextBoxColumn1
            // 
            this.familynameDataGridViewTextBoxColumn1.DataPropertyName = "family_name";
            this.familynameDataGridViewTextBoxColumn1.HeaderText = "family_name";
            this.familynameDataGridViewTextBoxColumn1.Name = "familynameDataGridViewTextBoxColumn1";
            this.familynameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fathernameDataGridViewTextBoxColumn1
            // 
            this.fathernameDataGridViewTextBoxColumn1.DataPropertyName = "father_name";
            this.fathernameDataGridViewTextBoxColumn1.HeaderText = "father_name";
            this.fathernameDataGridViewTextBoxColumn1.Name = "fathernameDataGridViewTextBoxColumn1";
            this.fathernameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "qualification";
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            this.qualificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "specialization";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditDoctor
            // 
            this.EditDoctor.HeaderText = "";
            this.EditDoctor.Name = "EditDoctor";
            this.EditDoctor.ReadOnly = true;
            this.EditDoctor.Text = "Edit";
            this.EditDoctor.UseColumnTextForButtonValue = true;
            // 
            // DeleteDoctor
            // 
            this.DeleteDoctor.HeaderText = "";
            this.DeleteDoctor.Name = "DeleteDoctor";
            this.DeleteDoctor.ReadOnly = true;
            this.DeleteDoctor.Text = "Delete";
            this.DeleteDoctor.UseColumnTextForButtonValue = true;
            // 
            // extResultBindingSource
            // 
            this.extResultBindingSource.DataSource = typeof(RDBMSHospital.ExtResult);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // familynameDataGridViewTextBoxColumn2
            // 
            this.familynameDataGridViewTextBoxColumn2.DataPropertyName = "family_name";
            this.familynameDataGridViewTextBoxColumn2.HeaderText = "family_name";
            this.familynameDataGridViewTextBoxColumn2.Name = "familynameDataGridViewTextBoxColumn2";
            this.familynameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // fathernameDataGridViewTextBoxColumn2
            // 
            this.fathernameDataGridViewTextBoxColumn2.DataPropertyName = "father_name";
            this.fathernameDataGridViewTextBoxColumn2.HeaderText = "father_name";
            this.fathernameDataGridViewTextBoxColumn2.Name = "fathernameDataGridViewTextBoxColumn2";
            this.fathernameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "Expr2";
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr3DataGridViewTextBoxColumn
            // 
            this.expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3";
            this.expr3DataGridViewTextBoxColumn.HeaderText = "Expr3";
            this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
            this.expr3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            this.diagnosisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outpatienttreatmentDataGridViewCheckBoxColumn
            // 
            this.outpatienttreatmentDataGridViewCheckBoxColumn.DataPropertyName = "outpatient_treatment";
            this.outpatienttreatmentDataGridViewCheckBoxColumn.HeaderText = "outpatient_treatment";
            this.outpatienttreatmentDataGridViewCheckBoxColumn.Name = "outpatienttreatmentDataGridViewCheckBoxColumn";
            this.outpatienttreatmentDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // countwithoutworkDataGridViewTextBoxColumn
            // 
            this.countwithoutworkDataGridViewTextBoxColumn.DataPropertyName = "count_without_work";
            this.countwithoutworkDataGridViewTextBoxColumn.HeaderText = "count_without_work";
            this.countwithoutworkDataGridViewTextBoxColumn.Name = "countwithoutworkDataGridViewTextBoxColumn";
            this.countwithoutworkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clinicalaccountDataGridViewCheckBoxColumn
            // 
            this.clinicalaccountDataGridViewCheckBoxColumn.DataPropertyName = "clinical_account";
            this.clinicalaccountDataGridViewCheckBoxColumn.HeaderText = "clinical_account";
            this.clinicalaccountDataGridViewCheckBoxColumn.Name = "clinicalaccountDataGridViewCheckBoxColumn";
            this.clinicalaccountDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // predictedDataGridViewTextBoxColumn
            // 
            this.predictedDataGridViewTextBoxColumn.DataPropertyName = "predicted";
            this.predictedDataGridViewTextBoxColumn.HeaderText = "predicted";
            this.predictedDataGridViewTextBoxColumn.Name = "predictedDataGridViewTextBoxColumn";
            this.predictedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factDataGridViewTextBoxColumn
            // 
            this.factDataGridViewTextBoxColumn.DataPropertyName = "fact";
            this.factDataGridViewTextBoxColumn.HeaderText = "fact";
            this.factDataGridViewTextBoxColumn.Name = "factDataGridViewTextBoxColumn";
            this.factDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultEdit
            // 
            this.resultEdit.HeaderText = "";
            this.resultEdit.Name = "resultEdit";
            this.resultEdit.ReadOnly = true;
            this.resultEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resultEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.resultEdit.Text = "Edit";
            this.resultEdit.UseColumnTextForButtonValue = true;
            // 
            // resultDelete
            // 
            this.resultDelete.HeaderText = "";
            this.resultDelete.Name = "resultDelete";
            this.resultDelete.ReadOnly = true;
            this.resultDelete.Text = "Delete";
            this.resultDelete.UseColumnTextForButtonValue = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.extPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extDoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extResultBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitrhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditPatient;
        private System.Windows.Forms.DataGridViewButtonColumn DeletePatient;
        private System.Windows.Forms.BindingSource extPatientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditDoctor;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteDoctor;
        private System.Windows.Forms.BindingSource extDoctorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathernameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn outpatienttreatmentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countwithoutworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clinicalaccountDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predictedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn resultEdit;
        private System.Windows.Forms.DataGridViewButtonColumn resultDelete;
        private System.Windows.Forms.BindingSource extResultBindingSource;
    }
}

