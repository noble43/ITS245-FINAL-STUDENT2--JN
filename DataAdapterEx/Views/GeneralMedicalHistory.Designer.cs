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
        private System.Windows.Forms.Button btnDelete;

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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelectPatient = new System.Windows.Forms.Button();
            this.btnDemographics = new System.Windows.Forms.Button();
            this.btnImmunizations = new System.Windows.Forms.Button();
            this.btnMedications = new System.Windows.Forms.Button();
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
            this.groupBoxHistory.Controls.Add(this.dgvHistory);
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
            this.groupBoxHistory.Location = new System.Drawing.Point(12, 50);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new System.Drawing.Size(760, 442);
            this.groupBoxHistory.TabIndex = 1;
            this.groupBoxHistory.TabStop = false;
            // 
            // dgvHistory
            // 
            this.dgvHistory.Location = new System.Drawing.Point(10, 20);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(740, 150);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.SelectionChanged += new System.EventHandler(this.dgvHistory_SelectionChanged);
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.Location = new System.Drawing.Point(10, 180);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(300, 20);
            this.txtMaritalStatus.TabIndex = 1;
            // 
            // txtEducation
            // 
            this.txtEducation.Location = new System.Drawing.Point(10, 210);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(300, 20);
            this.txtEducation.TabIndex = 2;
            // 
            // txtBehavioral
            // 
            this.txtBehavioral.Location = new System.Drawing.Point(10, 240);
            this.txtBehavioral.Name = "txtBehavioral";
            this.txtBehavioral.Size = new System.Drawing.Size(300, 20);
            this.txtBehavioral.TabIndex = 3;
            // 
            // txtTobacco
            // 
            this.txtTobacco.Location = new System.Drawing.Point(10, 270);
            this.txtTobacco.Name = "txtTobacco";
            this.txtTobacco.Size = new System.Drawing.Size(300, 20);
            this.txtTobacco.TabIndex = 4;
            // 
            // txtTobaccoQty
            // 
            this.txtTobaccoQty.Location = new System.Drawing.Point(10, 300);
            this.txtTobaccoQty.Name = "txtTobaccoQty";
            this.txtTobaccoQty.Size = new System.Drawing.Size(300, 20);
            this.txtTobaccoQty.TabIndex = 5;
            // 
            // txtTobaccoDur
            // 
            this.txtTobaccoDur.Location = new System.Drawing.Point(10, 330);
            this.txtTobaccoDur.Name = "txtTobaccoDur";
            this.txtTobaccoDur.Size = new System.Drawing.Size(300, 20);
            this.txtTobaccoDur.TabIndex = 6;
            // 
            // txtAlcohol
            // 
            this.txtAlcohol.Location = new System.Drawing.Point(10, 360);
            this.txtAlcohol.Name = "txtAlcohol";
            this.txtAlcohol.Size = new System.Drawing.Size(300, 20);
            this.txtAlcohol.TabIndex = 7;
            // 
            // txtAlcoholQty
            // 
            this.txtAlcoholQty.Location = new System.Drawing.Point(10, 390);
            this.txtAlcoholQty.Name = "txtAlcoholQty";
            this.txtAlcoholQty.Size = new System.Drawing.Size(300, 20);
            this.txtAlcoholQty.TabIndex = 8;
            // 
            // txtAlcoholDur
            // 
            this.txtAlcoholDur.Location = new System.Drawing.Point(10, 420);
            this.txtAlcoholDur.Name = "txtAlcoholDur";
            this.txtAlcoholDur.Size = new System.Drawing.Size(300, 20);
            this.txtAlcoholDur.TabIndex = 9;
            // 
            // txtDrug
            // 
            this.txtDrug.Location = new System.Drawing.Point(350, 180);
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.Size = new System.Drawing.Size(300, 20);
            this.txtDrug.TabIndex = 10;
            // 
            // txtDrugType
            // 
            this.txtDrugType.Location = new System.Drawing.Point(350, 210);
            this.txtDrugType.Name = "txtDrugType";
            this.txtDrugType.Size = new System.Drawing.Size(300, 20);
            this.txtDrugType.TabIndex = 11;
            // 
            // txtDrugDur
            // 
            this.txtDrugDur.Location = new System.Drawing.Point(350, 240);
            this.txtDrugDur.Name = "txtDrugDur";
            this.txtDrugDur.Size = new System.Drawing.Size(300, 20);
            this.txtDrugDur.TabIndex = 12;
            // 
            // txtDietary
            // 
            this.txtDietary.Location = new System.Drawing.Point(350, 270);
            this.txtDietary.Name = "txtDietary";
            this.txtDietary.Size = new System.Drawing.Size(300, 20);
            this.txtDietary.TabIndex = 13;
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(350, 300);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(300, 20);
            this.txtBloodType.TabIndex = 14;
            // 
            // txtRh
            // 
            this.txtRh.Location = new System.Drawing.Point(350, 330);
            this.txtRh.Name = "txtRh";
            this.txtRh.Size = new System.Drawing.Size(300, 20);
            this.txtRh.TabIndex = 15;
            // 
            // txtNumChildren
            // 
            this.txtNumChildren.Location = new System.Drawing.Point(350, 360);
            this.txtNumChildren.Name = "txtNumChildren";
            this.txtNumChildren.Size = new System.Drawing.Size(300, 20);
            this.txtNumChildren.TabIndex = 16;
            // 
            // txtLMP
            // 
            this.txtLMP.Location = new System.Drawing.Point(350, 390);
            this.txtLMP.Name = "txtLMP";
            this.txtLMP.Size = new System.Drawing.Size(300, 20);
            this.txtLMP.TabIndex = 17;
            // 
            // chkMensesYes
            // 
            this.chkMensesYes.Location = new System.Drawing.Point(350, 420);
            this.chkMensesYes.Name = "chkMensesYes";
            this.chkMensesYes.Size = new System.Drawing.Size(104, 24);
            this.chkMensesYes.TabIndex = 18;
            // 
            // chkMensesNo
            // 
            this.chkMensesNo.Location = new System.Drawing.Point(470, 420);
            this.chkMensesNo.Name = "chkMensesNo";
            this.chkMensesNo.Size = new System.Drawing.Size(104, 24);
            this.chkMensesNo.TabIndex = 19;
            // 
            // txtMensesFreq
            // 
            this.txtMensesFreq.Location = new System.Drawing.Point(350, 450);
            this.txtMensesFreq.Name = "txtMensesFreq";
            this.txtMensesFreq.Size = new System.Drawing.Size(300, 20);
            this.txtMensesFreq.TabIndex = 20;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(350, 480);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(300, 50);
            this.txtNotes.TabIndex = 21;
            // 
            // txtHxBy
            // 
            this.txtHxBy.Location = new System.Drawing.Point(350, 540);
            this.txtHxBy.Name = "txtHxBy";
            this.txtHxBy.Size = new System.Drawing.Size(300, 20);
            this.txtHxBy.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 498);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(92, 498);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(272, 498);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(362, 498);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelectPatient
            // 
            this.btnSelectPatient.Location = new System.Drawing.Point(502, 498);
            this.btnSelectPatient.Name = "btnSelectPatient";
            this.btnSelectPatient.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPatient.TabIndex = 7;
            this.btnSelectPatient.Text = "Select Patient";
            this.btnSelectPatient.Click += new System.EventHandler(this.btnSelectPatient_Click);
            // 
            // btnDemographics
            // 
            this.btnDemographics.Location = new System.Drawing.Point(502, 528);
            this.btnDemographics.Name = "btnDemographics";
            this.btnDemographics.Size = new System.Drawing.Size(75, 23);
            this.btnDemographics.TabIndex = 8;
            this.btnDemographics.Text = "Demographics";
            // 
            // btnImmunizations
            // 
            this.btnImmunizations.Location = new System.Drawing.Point(622, 498);
            this.btnImmunizations.Name = "btnImmunizations";
            this.btnImmunizations.Size = new System.Drawing.Size(75, 23);
            this.btnImmunizations.TabIndex = 9;
            this.btnImmunizations.Text = "Immunizations";
            // 
            // btnMedications
            // 
            this.btnMedications.Location = new System.Drawing.Point(622, 528);
            this.btnMedications.Name = "btnMedications";
            this.btnMedications.Size = new System.Drawing.Size(75, 23);
            this.btnMedications.TabIndex = 10;
            this.btnMedications.Text = "Medications";
            // 
            // GeneralMedicalHistory
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Name = "GeneralMedicalHistory";
            this.Text = "General Medical History";
            this.groupBoxHistory.ResumeLayout(false);
            this.groupBoxHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
