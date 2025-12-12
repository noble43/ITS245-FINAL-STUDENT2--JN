namespace DataAdapterEx.Views
{
    partial class GeneralMedicalHistory
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblPatientHeader;
        private System.Windows.Forms.GroupBox groupBoxHistory;
        private System.Windows.Forms.DataGridView dgvHistory;

        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.TextBox txtBehavioral;
        private System.Windows.Forms.TextBox txtTobacco;
        private System.Windows.Forms.TextBox txtTobaccoQty;
        private System.Windows.Forms.TextBox txtTobaccoDur;
        private System.Windows.Forms.TextBox txtAlcohol;
        private System.Windows.Forms.TextBox txtAlcoholQty;
        private System.Windows.Forms.TextBox txtAlcoholDur;
        private System.Windows.Forms.TextBox txtDrug;
        private System.Windows.Forms.TextBox txtDrugType;
        private System.Windows.Forms.TextBox txtDrugDur;
        private System.Windows.Forms.TextBox txtDietary;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.TextBox txtRh;
        private System.Windows.Forms.TextBox txtNumChildren;
        private System.Windows.Forms.TextBox txtLMP;
        private System.Windows.Forms.CheckBox chkMensesYes;
        private System.Windows.Forms.CheckBox chkMensesNo;
        private System.Windows.Forms.TextBox txtMensesFreq;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtHxBy;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;

        private System.Windows.Forms.Button btnSelectPatient;
        private System.Windows.Forms.Button btnDemographics;
        private System.Windows.Forms.Button btnImmunizations;
        private System.Windows.Forms.Button btnMedications;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblPatientHeader = new System.Windows.Forms.Label();
            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.lblHxBy = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblMensesFreq = new System.Windows.Forms.Label();
            this.lblMenses = new System.Windows.Forms.Label();
            this.lblLMP = new System.Windows.Forms.Label();
            this.lblNumChildren = new System.Windows.Forms.Label();
            this.lblDrugType = new System.Windows.Forms.Label();
            this.lblRh = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblDietary = new System.Windows.Forms.Label();
            this.lblDrugDur = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDrug = new System.Windows.Forms.Label();
            this.lblAlcoholDur = new System.Windows.Forms.Label();
            this.lblAlcoholQty = new System.Windows.Forms.Label();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.lblTobaccoDur = new System.Windows.Forms.Label();
            this.lblTobaccoQty = new System.Windows.Forms.Label();
            this.lblTobacco = new System.Windows.Forms.Label();
            this.lblBehavioral = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.txtBehavioral = new System.Windows.Forms.TextBox();
            this.txtTobacco = new System.Windows.Forms.TextBox();
            this.txtTobaccoQty = new System.Windows.Forms.TextBox();
            this.txtTobaccoDur = new System.Windows.Forms.TextBox();
            this.txtAlcohol = new System.Windows.Forms.TextBox();
            this.txtAlcoholQty = new System.Windows.Forms.TextBox();
            this.txtAlcoholDur = new System.Windows.Forms.TextBox();
            this.txtDrug = new System.Windows.Forms.TextBox();
            this.txtDrugType = new System.Windows.Forms.TextBox();
            this.txtDrugDur = new System.Windows.Forms.TextBox();
            this.txtDietary = new System.Windows.Forms.TextBox();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.txtRh = new System.Windows.Forms.TextBox();
            this.txtNumChildren = new System.Windows.Forms.TextBox();
            this.txtLMP = new System.Windows.Forms.TextBox();
            this.chkMensesYes = new System.Windows.Forms.CheckBox();
            this.chkMensesNo = new System.Windows.Forms.CheckBox();
            this.txtMensesFreq = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtHxBy = new System.Windows.Forms.TextBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSelectPatient = new System.Windows.Forms.Button();
            this.btnDemographics = new System.Windows.Forms.Button();
            this.btnImmunizations = new System.Windows.Forms.Button();
            this.btnMedications = new System.Windows.Forms.Button();
            this.lblPatientIDSelect = new System.Windows.Forms.Label();
            this.txtPatientIDSelect = new System.Windows.Forms.TextBox();
            this.btnPatientIDSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientHeader
            // 
            this.lblPatientHeader.BackColor = System.Drawing.Color.LightYellow;
            this.lblPatientHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatientHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPatientHeader.Location = new System.Drawing.Point(0, 0);
            this.lblPatientHeader.Name = "lblPatientHeader";
            this.lblPatientHeader.Size = new System.Drawing.Size(784, 40);
            this.lblPatientHeader.TabIndex = 0;
            this.lblPatientHeader.Text = "Patient Name | Age: XX";
            this.lblPatientHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxHistory
            // 
            this.groupBoxHistory.Controls.Add(this.lblHxBy);
            this.groupBoxHistory.Controls.Add(this.lblNotes);
            this.groupBoxHistory.Controls.Add(this.lblMensesFreq);
            this.groupBoxHistory.Controls.Add(this.lblMenses);
            this.groupBoxHistory.Controls.Add(this.lblLMP);
            this.groupBoxHistory.Controls.Add(this.lblNumChildren);
            this.groupBoxHistory.Controls.Add(this.lblDrugType);
            this.groupBoxHistory.Controls.Add(this.lblRh);
            this.groupBoxHistory.Controls.Add(this.lblBloodType);
            this.groupBoxHistory.Controls.Add(this.lblDietary);
            this.groupBoxHistory.Controls.Add(this.lblDrugDur);
            this.groupBoxHistory.Controls.Add(this.label10);
            this.groupBoxHistory.Controls.Add(this.lblDrug);
            this.groupBoxHistory.Controls.Add(this.lblAlcoholDur);
            this.groupBoxHistory.Controls.Add(this.lblAlcoholQty);
            this.groupBoxHistory.Controls.Add(this.lblAlcohol);
            this.groupBoxHistory.Controls.Add(this.lblTobaccoDur);
            this.groupBoxHistory.Controls.Add(this.lblTobaccoQty);
            this.groupBoxHistory.Controls.Add(this.lblTobacco);
            this.groupBoxHistory.Controls.Add(this.lblBehavioral);
            this.groupBoxHistory.Controls.Add(this.lblEducation);
            this.groupBoxHistory.Controls.Add(this.lblMaritalStatus);
            this.groupBoxHistory.Controls.Add(this.txtMaritalStatus);
            this.groupBoxHistory.Controls.Add(this.txtEducation);
            this.groupBoxHistory.Controls.Add(this.txtBehavioral);
            this.groupBoxHistory.Controls.Add(this.txtTobacco);
            this.groupBoxHistory.Controls.Add(this.txtTobaccoQty);
            this.groupBoxHistory.Controls.Add(this.txtTobaccoDur);
            this.groupBoxHistory.Controls.Add(this.txtAlcohol);
            this.groupBoxHistory.Controls.Add(this.txtAlcoholQty);
            this.groupBoxHistory.Controls.Add(this.txtAlcoholDur);
            this.groupBoxHistory.Controls.Add(this.txtDrug);
            this.groupBoxHistory.Controls.Add(this.txtDrugType);
            this.groupBoxHistory.Controls.Add(this.txtDrugDur);
            this.groupBoxHistory.Controls.Add(this.txtDietary);
            this.groupBoxHistory.Controls.Add(this.txtBloodType);
            this.groupBoxHistory.Controls.Add(this.txtRh);
            this.groupBoxHistory.Controls.Add(this.txtNumChildren);
            this.groupBoxHistory.Controls.Add(this.txtLMP);
            this.groupBoxHistory.Controls.Add(this.chkMensesYes);
            this.groupBoxHistory.Controls.Add(this.chkMensesNo);
            this.groupBoxHistory.Controls.Add(this.txtMensesFreq);
            this.groupBoxHistory.Controls.Add(this.txtNotes);
            this.groupBoxHistory.Controls.Add(this.txtHxBy);
            this.groupBoxHistory.Location = new System.Drawing.Point(12, 118);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new System.Drawing.Size(760, 339);
            this.groupBoxHistory.TabIndex = 1;
            this.groupBoxHistory.TabStop = false;
            // 
            // lblHxBy
            // 
            this.lblHxBy.AutoSize = true;
            this.lblHxBy.Location = new System.Drawing.Point(401, 310);
            this.lblHxBy.Name = "lblHxBy";
            this.lblHxBy.Size = new System.Drawing.Size(81, 13);
            this.lblHxBy.TabIndex = 43;
            this.lblHxBy.Text = "Hx Obtained By";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(29, 284);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 42;
            this.lblNotes.Text = "Notes";
            // 
            // lblMensesFreq
            // 
            this.lblMensesFreq.AutoSize = true;
            this.lblMensesFreq.Location = new System.Drawing.Point(401, 284);
            this.lblMensesFreq.Name = "lblMensesFreq";
            this.lblMensesFreq.Size = new System.Drawing.Size(97, 13);
            this.lblMensesFreq.TabIndex = 41;
            this.lblMensesFreq.Text = "Menses Frequency";
            // 
            // lblMenses
            // 
            this.lblMenses.AutoSize = true;
            this.lblMenses.Location = new System.Drawing.Point(401, 258);
            this.lblMenses.Name = "lblMenses";
            this.lblMenses.Size = new System.Drawing.Size(84, 13);
            this.lblMenses.TabIndex = 40;
            this.lblMenses.Text = "Monthly Menses";
            // 
            // lblLMP
            // 
            this.lblLMP.AutoSize = true;
            this.lblLMP.Location = new System.Drawing.Point(401, 228);
            this.lblLMP.Name = "lblLMP";
            this.lblLMP.Size = new System.Drawing.Size(62, 13);
            this.lblLMP.TabIndex = 39;
            this.lblLMP.Text = "LMP Status";
            // 
            // lblNumChildren
            // 
            this.lblNumChildren.AutoSize = true;
            this.lblNumChildren.Location = new System.Drawing.Point(401, 198);
            this.lblNumChildren.Name = "lblNumChildren";
            this.lblNumChildren.Size = new System.Drawing.Size(97, 13);
            this.lblNumChildren.TabIndex = 38;
            this.lblNumChildren.Text = "Number of Children";
            // 
            // lblDrugType
            // 
            this.lblDrugType.AutoSize = true;
            this.lblDrugType.Location = new System.Drawing.Point(401, 48);
            this.lblDrugType.Name = "lblDrugType";
            this.lblDrugType.Size = new System.Drawing.Size(54, 13);
            this.lblDrugType.TabIndex = 38;
            this.lblDrugType.Text = "DrugType";
            // 
            // lblRh
            // 
            this.lblRh.AutoSize = true;
            this.lblRh.Location = new System.Drawing.Point(401, 168);
            this.lblRh.Name = "lblRh";
            this.lblRh.Size = new System.Drawing.Size(21, 13);
            this.lblRh.TabIndex = 37;
            this.lblRh.Text = "Rh";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(401, 138);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(58, 13);
            this.lblBloodType.TabIndex = 36;
            this.lblBloodType.Text = "BloodType";
            // 
            // lblDietary
            // 
            this.lblDietary.AutoSize = true;
            this.lblDietary.Location = new System.Drawing.Point(401, 108);
            this.lblDietary.Name = "lblDietary";
            this.lblDietary.Size = new System.Drawing.Size(40, 13);
            this.lblDietary.TabIndex = 35;
            this.lblDietary.Text = "Dietary";
            // 
            // lblDrugDur
            // 
            this.lblDrugDur.AutoSize = true;
            this.lblDrugDur.Location = new System.Drawing.Point(401, 78);
            this.lblDrugDur.Name = "lblDrugDur";
            this.lblDrugDur.Size = new System.Drawing.Size(47, 13);
            this.lblDrugDur.TabIndex = 34;
            this.lblDrugDur.Text = "DrugDur";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "DrugType";
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Location = new System.Drawing.Point(401, 18);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(30, 13);
            this.lblDrug.TabIndex = 32;
            this.lblDrug.Text = "Drug";
            // 
            // lblAlcoholDur
            // 
            this.lblAlcoholDur.AutoSize = true;
            this.lblAlcoholDur.Location = new System.Drawing.Point(30, 258);
            this.lblAlcoholDur.Name = "lblAlcoholDur";
            this.lblAlcoholDur.Size = new System.Drawing.Size(59, 13);
            this.lblAlcoholDur.TabIndex = 31;
            this.lblAlcoholDur.Text = "AlcoholDur";
            // 
            // lblAlcoholQty
            // 
            this.lblAlcoholQty.AutoSize = true;
            this.lblAlcoholQty.Location = new System.Drawing.Point(30, 228);
            this.lblAlcoholQty.Name = "lblAlcoholQty";
            this.lblAlcoholQty.Size = new System.Drawing.Size(58, 13);
            this.lblAlcoholQty.TabIndex = 30;
            this.lblAlcoholQty.Text = "AlcoholQty";
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.AutoSize = true;
            this.lblAlcohol.Location = new System.Drawing.Point(30, 198);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(42, 13);
            this.lblAlcohol.TabIndex = 29;
            this.lblAlcohol.Text = "Alcohol";
            // 
            // lblTobaccoDur
            // 
            this.lblTobaccoDur.AutoSize = true;
            this.lblTobaccoDur.Location = new System.Drawing.Point(30, 168);
            this.lblTobaccoDur.Name = "lblTobaccoDur";
            this.lblTobaccoDur.Size = new System.Drawing.Size(67, 13);
            this.lblTobaccoDur.TabIndex = 28;
            this.lblTobaccoDur.Text = "TobaccoDur";
            // 
            // lblTobaccoQty
            // 
            this.lblTobaccoQty.AutoSize = true;
            this.lblTobaccoQty.Location = new System.Drawing.Point(30, 138);
            this.lblTobaccoQty.Name = "lblTobaccoQty";
            this.lblTobaccoQty.Size = new System.Drawing.Size(66, 13);
            this.lblTobaccoQty.TabIndex = 27;
            this.lblTobaccoQty.Text = "TobaccoQty";
            // 
            // lblTobacco
            // 
            this.lblTobacco.AutoSize = true;
            this.lblTobacco.Location = new System.Drawing.Point(30, 108);
            this.lblTobacco.Name = "lblTobacco";
            this.lblTobacco.Size = new System.Drawing.Size(50, 13);
            this.lblTobacco.TabIndex = 26;
            this.lblTobacco.Text = "Tobacco";
            // 
            // lblBehavioral
            // 
            this.lblBehavioral.AutoSize = true;
            this.lblBehavioral.Location = new System.Drawing.Point(30, 78);
            this.lblBehavioral.Name = "lblBehavioral";
            this.lblBehavioral.Size = new System.Drawing.Size(92, 13);
            this.lblBehavioral.TabIndex = 25;
            this.lblBehavioral.Text = "Behavioral History";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(30, 48);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(55, 13);
            this.lblEducation.TabIndex = 24;
            this.lblEducation.Text = "Education";
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(30, 18);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(71, 13);
            this.lblMaritalStatus.TabIndex = 23;
            this.lblMaritalStatus.Text = "Marital Status";
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.Location = new System.Drawing.Point(107, 15);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(230, 20);
            this.txtMaritalStatus.TabIndex = 1;
            // 
            // txtEducation
            // 
            this.txtEducation.Location = new System.Drawing.Point(91, 45);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(230, 20);
            this.txtEducation.TabIndex = 2;
            // 
            // txtBehavioral
            // 
            this.txtBehavioral.Location = new System.Drawing.Point(128, 75);
            this.txtBehavioral.Name = "txtBehavioral";
            this.txtBehavioral.Size = new System.Drawing.Size(230, 20);
            this.txtBehavioral.TabIndex = 3;
            // 
            // txtTobacco
            // 
            this.txtTobacco.Location = new System.Drawing.Point(86, 105);
            this.txtTobacco.Name = "txtTobacco";
            this.txtTobacco.Size = new System.Drawing.Size(230, 20);
            this.txtTobacco.TabIndex = 4;
            // 
            // txtTobaccoQty
            // 
            this.txtTobaccoQty.Location = new System.Drawing.Point(102, 135);
            this.txtTobaccoQty.Name = "txtTobaccoQty";
            this.txtTobaccoQty.Size = new System.Drawing.Size(230, 20);
            this.txtTobaccoQty.TabIndex = 5;
            // 
            // txtTobaccoDur
            // 
            this.txtTobaccoDur.Location = new System.Drawing.Point(102, 165);
            this.txtTobaccoDur.Name = "txtTobaccoDur";
            this.txtTobaccoDur.Size = new System.Drawing.Size(230, 20);
            this.txtTobaccoDur.TabIndex = 6;
            // 
            // txtAlcohol
            // 
            this.txtAlcohol.Location = new System.Drawing.Point(78, 195);
            this.txtAlcohol.Name = "txtAlcohol";
            this.txtAlcohol.Size = new System.Drawing.Size(230, 20);
            this.txtAlcohol.TabIndex = 7;
            // 
            // txtAlcoholQty
            // 
            this.txtAlcoholQty.Location = new System.Drawing.Point(94, 225);
            this.txtAlcoholQty.Name = "txtAlcoholQty";
            this.txtAlcoholQty.Size = new System.Drawing.Size(230, 20);
            this.txtAlcoholQty.TabIndex = 8;
            // 
            // txtAlcoholDur
            // 
            this.txtAlcoholDur.Location = new System.Drawing.Point(95, 253);
            this.txtAlcoholDur.Name = "txtAlcoholDur";
            this.txtAlcoholDur.Size = new System.Drawing.Size(230, 20);
            this.txtAlcoholDur.TabIndex = 9;
            // 
            // txtDrug
            // 
            this.txtDrug.Location = new System.Drawing.Point(437, 15);
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.Size = new System.Drawing.Size(230, 20);
            this.txtDrug.TabIndex = 10;
            // 
            // txtDrugType
            // 
            this.txtDrugType.Location = new System.Drawing.Point(461, 45);
            this.txtDrugType.Name = "txtDrugType";
            this.txtDrugType.Size = new System.Drawing.Size(230, 20);
            this.txtDrugType.TabIndex = 11;
            // 
            // txtDrugDur
            // 
            this.txtDrugDur.Location = new System.Drawing.Point(454, 75);
            this.txtDrugDur.Name = "txtDrugDur";
            this.txtDrugDur.Size = new System.Drawing.Size(230, 20);
            this.txtDrugDur.TabIndex = 12;
            // 
            // txtDietary
            // 
            this.txtDietary.Location = new System.Drawing.Point(447, 105);
            this.txtDietary.Name = "txtDietary";
            this.txtDietary.Size = new System.Drawing.Size(230, 20);
            this.txtDietary.TabIndex = 13;
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(465, 135);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(230, 20);
            this.txtBloodType.TabIndex = 14;
            // 
            // txtRh
            // 
            this.txtRh.Location = new System.Drawing.Point(428, 165);
            this.txtRh.Name = "txtRh";
            this.txtRh.Size = new System.Drawing.Size(230, 20);
            this.txtRh.TabIndex = 15;
            // 
            // txtNumChildren
            // 
            this.txtNumChildren.Location = new System.Drawing.Point(504, 195);
            this.txtNumChildren.Name = "txtNumChildren";
            this.txtNumChildren.Size = new System.Drawing.Size(230, 20);
            this.txtNumChildren.TabIndex = 16;
            // 
            // txtLMP
            // 
            this.txtLMP.Location = new System.Drawing.Point(504, 281);
            this.txtLMP.Name = "txtLMP";
            this.txtLMP.Size = new System.Drawing.Size(230, 20);
            this.txtLMP.TabIndex = 17;
            // 
            // chkMensesYes
            // 
            this.chkMensesYes.Location = new System.Drawing.Point(491, 253);
            this.chkMensesYes.Name = "chkMensesYes";
            this.chkMensesYes.Size = new System.Drawing.Size(75, 24);
            this.chkMensesYes.TabIndex = 18;
            this.chkMensesYes.Text = "Yes";
            // 
            // chkMensesNo
            // 
            this.chkMensesNo.Location = new System.Drawing.Point(572, 253);
            this.chkMensesNo.Name = "chkMensesNo";
            this.chkMensesNo.Size = new System.Drawing.Size(75, 24);
            this.chkMensesNo.TabIndex = 19;
            this.chkMensesNo.Text = "No";
            // 
            // txtMensesFreq
            // 
            this.txtMensesFreq.Location = new System.Drawing.Point(478, 225);
            this.txtMensesFreq.Name = "txtMensesFreq";
            this.txtMensesFreq.Size = new System.Drawing.Size(230, 20);
            this.txtMensesFreq.TabIndex = 20;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(70, 281);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(254, 50);
            this.txtNotes.TabIndex = 21;
            // 
            // txtHxBy
            // 
            this.txtHxBy.Location = new System.Drawing.Point(488, 307);
            this.txtHxBy.Name = "txtHxBy";
            this.txtHxBy.Size = new System.Drawing.Size(230, 20);
            this.txtHxBy.TabIndex = 22;
            // 
            // dgvHistory
            // 
            this.dgvHistory.Location = new System.Drawing.Point(21, 43);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(740, 69);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.SelectionChanged += new System.EventHandler(this.dgvHistory_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Azure;
            this.btnAdd.Location = new System.Drawing.Point(20, 478);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Azure;
            this.btnModify.Location = new System.Drawing.Point(101, 478);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.Location = new System.Drawing.Point(182, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Azure;
            this.btnUndo.Location = new System.Drawing.Point(263, 478);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSelectPatient
            // 
            this.btnSelectPatient.BackColor = System.Drawing.Color.Azure;
            this.btnSelectPatient.Location = new System.Drawing.Point(516, 478);
            this.btnSelectPatient.Name = "btnSelectPatient";
            this.btnSelectPatient.Size = new System.Drawing.Size(114, 23);
            this.btnSelectPatient.TabIndex = 7;
            this.btnSelectPatient.Text = "Select Patient";
            this.btnSelectPatient.UseVisualStyleBackColor = false;
            this.btnSelectPatient.Click += new System.EventHandler(this.btnSelectPatient_Click);
            // 
            // btnDemographics
            // 
            this.btnDemographics.BackColor = System.Drawing.Color.Azure;
            this.btnDemographics.Location = new System.Drawing.Point(516, 508);
            this.btnDemographics.Name = "btnDemographics";
            this.btnDemographics.Size = new System.Drawing.Size(114, 23);
            this.btnDemographics.TabIndex = 8;
            this.btnDemographics.Text = "Demographics";
            this.btnDemographics.UseVisualStyleBackColor = false;
            this.btnDemographics.Click += new System.EventHandler(this.btnDemographics_Click);
            // 
            // btnImmunizations
            // 
            this.btnImmunizations.BackColor = System.Drawing.Color.Azure;
            this.btnImmunizations.Location = new System.Drawing.Point(636, 478);
            this.btnImmunizations.Name = "btnImmunizations";
            this.btnImmunizations.Size = new System.Drawing.Size(114, 23);
            this.btnImmunizations.TabIndex = 9;
            this.btnImmunizations.Text = "Immunizations";
            this.btnImmunizations.UseVisualStyleBackColor = false;
            this.btnImmunizations.Click += new System.EventHandler(this.btnImmunizations_Click);
            // 
            // btnMedications
            // 
            this.btnMedications.BackColor = System.Drawing.Color.Azure;
            this.btnMedications.Location = new System.Drawing.Point(636, 508);
            this.btnMedications.Name = "btnMedications";
            this.btnMedications.Size = new System.Drawing.Size(114, 23);
            this.btnMedications.TabIndex = 10;
            this.btnMedications.Text = "Medications";
            this.btnMedications.UseVisualStyleBackColor = false;
            this.btnMedications.Click += new System.EventHandler(this.btnMedications_Click);
            // 
            // lblPatientIDSelect
            // 
            this.lblPatientIDSelect.AutoSize = true;
            this.lblPatientIDSelect.Location = new System.Drawing.Point(18, 518);
            this.lblPatientIDSelect.Name = "lblPatientIDSelect";
            this.lblPatientIDSelect.Size = new System.Drawing.Size(87, 13);
            this.lblPatientIDSelect.TabIndex = 43;
            this.lblPatientIDSelect.Text = "Patient ID Select";
            // 
            // txtPatientIDSelect
            // 
            this.txtPatientIDSelect.Location = new System.Drawing.Point(111, 515);
            this.txtPatientIDSelect.Name = "txtPatientIDSelect";
            this.txtPatientIDSelect.Size = new System.Drawing.Size(58, 20);
            this.txtPatientIDSelect.TabIndex = 43;
            // 
            // btnPatientIDSelect
            // 
            this.btnPatientIDSelect.BackColor = System.Drawing.Color.Azure;
            this.btnPatientIDSelect.Location = new System.Drawing.Point(182, 513);
            this.btnPatientIDSelect.Name = "btnPatientIDSelect";
            this.btnPatientIDSelect.Size = new System.Drawing.Size(75, 23);
            this.btnPatientIDSelect.TabIndex = 44;
            this.btnPatientIDSelect.Text = "Load Patient";
            this.btnPatientIDSelect.UseVisualStyleBackColor = false;
            this.btnPatientIDSelect.Click += new System.EventHandler(this.btnPatientIDSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Azure;
            this.btnDelete.Location = new System.Drawing.Point(344, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GeneralMedicalHistory
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 539);
            this.Controls.Add(this.btnPatientIDSelect);
            this.Controls.Add(this.txtPatientIDSelect);
            this.Controls.Add(this.lblPatientIDSelect);
            this.Controls.Add(this.lblPatientHeader);
            this.Controls.Add(this.groupBoxHistory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelectPatient);
            this.Controls.Add(this.btnDemographics);
            this.Controls.Add(this.btnImmunizations);
            this.Controls.Add(this.btnMedications);
            this.Controls.Add(this.dgvHistory);
            this.Name = "GeneralMedicalHistory";
            this.Text = "General Medical History";
            this.groupBoxHistory.ResumeLayout(false);
            this.groupBoxHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLMP;
        private System.Windows.Forms.Label lblNumChildren;
        private System.Windows.Forms.Label lblDrugType;
        private System.Windows.Forms.Label lblRh;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblDietary;
        private System.Windows.Forms.Label lblDrugDur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.Label lblAlcoholDur;
        private System.Windows.Forms.Label lblAlcoholQty;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.Label lblTobaccoDur;
        private System.Windows.Forms.Label lblTobaccoQty;
        private System.Windows.Forms.Label lblTobacco;
        private System.Windows.Forms.Label lblBehavioral;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblMenses;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblMensesFreq;
        private System.Windows.Forms.Label lblPatientIDSelect;
        private System.Windows.Forms.TextBox txtPatientIDSelect;
        private System.Windows.Forms.Button btnPatientIDSelect;
        private System.Windows.Forms.Label lblHxBy;
        private System.Windows.Forms.Button btnDelete;
    }
}
