namespace DataAdapterEx.Views
{
    partial class MedicationHistoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMedications = new System.Windows.Forms.DataGridView();
            this.txtMedication = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectPatient = new System.Windows.Forms.Button();
            this.btnDemographics = new System.Windows.Forms.Button();
            this.btnImmunizations = new System.Windows.Forms.Button();
            this.btnGeneralHistory = new System.Windows.Forms.Button();
            this.groupBoxMedications = new System.Windows.Forms.GroupBox();
            this.txtPrescriptionHCP = new System.Windows.Forms.TextBox();
            this.lblPrescriptionHCP = new System.Windows.Forms.Label();
            this.txtMedicationEndDate = new System.Windows.Forms.TextBox();
            this.lblMedicationEndDate = new System.Windows.Forms.Label();
            this.txtMedicationStartDate = new System.Windows.Forms.TextBox();
            this.lblMedicationStartDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            this.groupBoxMedications.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedications
            // 
            this.dgvMedications.Location = new System.Drawing.Point(12, 12);
            this.dgvMedications.MultiSelect = false;
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.ReadOnly = true;
            this.dgvMedications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedications.Size = new System.Drawing.Size(624, 63);
            this.dgvMedications.TabIndex = 0;
            this.dgvMedications.SelectionChanged += new System.EventHandler(this.dgvMedications_SelectionChanged);
            // 
            // txtMedication
            // 
            this.txtMedication.Location = new System.Drawing.Point(153, 86);
            this.txtMedication.Name = "txtMedication";
            this.txtMedication.Size = new System.Drawing.Size(100, 20);
            this.txtMedication.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(153, 126);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(153, 166);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 3;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(153, 206);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(100, 60);
            this.txtInstructions.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Azure;
            this.btnAdd.Location = new System.Drawing.Point(12, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.Location = new System.Drawing.Point(90, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Azure;
            this.btnDelete.Location = new System.Drawing.Point(170, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Azure;
            this.btnUndo.Location = new System.Drawing.Point(250, 458);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(45, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medication";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(45, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Unit";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(45, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Instructions";
            // 
            // btnSelectPatient
            // 
            this.btnSelectPatient.BackColor = System.Drawing.Color.Azure;
            this.btnSelectPatient.Location = new System.Drawing.Point(402, 458);
            this.btnSelectPatient.Name = "btnSelectPatient";
            this.btnSelectPatient.Size = new System.Drawing.Size(114, 23);
            this.btnSelectPatient.TabIndex = 13;
            this.btnSelectPatient.Text = "Select Patient";
            this.btnSelectPatient.UseVisualStyleBackColor = false;
            this.btnSelectPatient.Click += new System.EventHandler(this.btnSelectPatient_Click);
            // 
            // btnDemographics
            // 
            this.btnDemographics.BackColor = System.Drawing.Color.Azure;
            this.btnDemographics.Location = new System.Drawing.Point(402, 488);
            this.btnDemographics.Name = "btnDemographics";
            this.btnDemographics.Size = new System.Drawing.Size(114, 23);
            this.btnDemographics.TabIndex = 14;
            this.btnDemographics.Text = "Demographics";
            this.btnDemographics.UseVisualStyleBackColor = false;
            this.btnDemographics.Click += new System.EventHandler(this.btnDemographics_Click);
            // 
            // btnImmunizations
            // 
            this.btnImmunizations.BackColor = System.Drawing.Color.Azure;
            this.btnImmunizations.Location = new System.Drawing.Point(522, 458);
            this.btnImmunizations.Name = "btnImmunizations";
            this.btnImmunizations.Size = new System.Drawing.Size(114, 23);
            this.btnImmunizations.TabIndex = 15;
            this.btnImmunizations.Text = "Immunizations";
            this.btnImmunizations.UseVisualStyleBackColor = false;
            this.btnImmunizations.Click += new System.EventHandler(this.btnImmunizations_Click);
            // 
            // btnGeneralHistory
            // 
            this.btnGeneralHistory.BackColor = System.Drawing.Color.Azure;
            this.btnGeneralHistory.Location = new System.Drawing.Point(522, 488);
            this.btnGeneralHistory.Name = "btnGeneralHistory";
            this.btnGeneralHistory.Size = new System.Drawing.Size(114, 23);
            this.btnGeneralHistory.TabIndex = 16;
            this.btnGeneralHistory.Text = "Medical History";
            this.btnGeneralHistory.UseVisualStyleBackColor = false;
            this.btnGeneralHistory.Click += new System.EventHandler(this.btnMedications_Click);
            // 
            // groupBoxMedications
            // 
            this.groupBoxMedications.Controls.Add(this.txtPrescriptionHCP);
            this.groupBoxMedications.Controls.Add(this.lblPrescriptionHCP);
            this.groupBoxMedications.Controls.Add(this.txtMedicationEndDate);
            this.groupBoxMedications.Controls.Add(this.lblMedicationEndDate);
            this.groupBoxMedications.Controls.Add(this.txtMedicationStartDate);
            this.groupBoxMedications.Controls.Add(this.lblMedicationStartDate);
            this.groupBoxMedications.Controls.Add(this.txtMedication);
            this.groupBoxMedications.Controls.Add(this.txtAmount);
            this.groupBoxMedications.Controls.Add(this.label1);
            this.groupBoxMedications.Controls.Add(this.txtUnit);
            this.groupBoxMedications.Controls.Add(this.label4);
            this.groupBoxMedications.Controls.Add(this.txtInstructions);
            this.groupBoxMedications.Controls.Add(this.label3);
            this.groupBoxMedications.Controls.Add(this.label2);
            this.groupBoxMedications.Location = new System.Drawing.Point(3, 99);
            this.groupBoxMedications.Name = "groupBoxMedications";
            this.groupBoxMedications.Size = new System.Drawing.Size(642, 281);
            this.groupBoxMedications.TabIndex = 17;
            this.groupBoxMedications.TabStop = false;
            // 
            // txtPrescriptionHCP
            // 
            this.txtPrescriptionHCP.Location = new System.Drawing.Point(398, 163);
            this.txtPrescriptionHCP.Name = "txtPrescriptionHCP";
            this.txtPrescriptionHCP.Size = new System.Drawing.Size(100, 20);
            this.txtPrescriptionHCP.TabIndex = 17;
            // 
            // lblPrescriptionHCP
            // 
            this.lblPrescriptionHCP.Location = new System.Drawing.Point(280, 163);
            this.lblPrescriptionHCP.Name = "lblPrescriptionHCP";
            this.lblPrescriptionHCP.Size = new System.Drawing.Size(100, 23);
            this.lblPrescriptionHCP.TabIndex = 18;
            this.lblPrescriptionHCP.Text = "Prescription HCP";
            // 
            // txtMedicationEndDate
            // 
            this.txtMedicationEndDate.Location = new System.Drawing.Point(398, 126);
            this.txtMedicationEndDate.Name = "txtMedicationEndDate";
            this.txtMedicationEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtMedicationEndDate.TabIndex = 15;
            // 
            // lblMedicationEndDate
            // 
            this.lblMedicationEndDate.Location = new System.Drawing.Point(280, 126);
            this.lblMedicationEndDate.Name = "lblMedicationEndDate";
            this.lblMedicationEndDate.Size = new System.Drawing.Size(115, 23);
            this.lblMedicationEndDate.TabIndex = 16;
            this.lblMedicationEndDate.Text = "Medication End Date";
            // 
            // txtMedicationStartDate
            // 
            this.txtMedicationStartDate.Location = new System.Drawing.Point(398, 83);
            this.txtMedicationStartDate.Name = "txtMedicationStartDate";
            this.txtMedicationStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtMedicationStartDate.TabIndex = 13;
            // 
            // lblMedicationStartDate
            // 
            this.lblMedicationStartDate.Location = new System.Drawing.Point(280, 86);
            this.lblMedicationStartDate.Name = "lblMedicationStartDate";
            this.lblMedicationStartDate.Size = new System.Drawing.Size(115, 23);
            this.lblMedicationStartDate.TabIndex = 14;
            this.lblMedicationStartDate.Text = "Medication Start Date";
            // 
            // MedicationHistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MedicationHistoryForm";
            this.Text = "Medication History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            this.groupBoxMedications.ResumeLayout(false);
            this.groupBoxMedications.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvMedications;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectPatient;
        private System.Windows.Forms.Button btnDemographics;
        private System.Windows.Forms.Button btnImmunizations;
        private System.Windows.Forms.Button btnGeneralHistory;
        private System.Windows.Forms.GroupBox groupBoxMedications;
        private System.Windows.Forms.TextBox txtPrescriptionHCP;
        private System.Windows.Forms.Label lblPrescriptionHCP;
        private System.Windows.Forms.TextBox txtMedicationEndDate;
        private System.Windows.Forms.Label lblMedicationEndDate;
        private System.Windows.Forms.TextBox txtMedicationStartDate;
        private System.Windows.Forms.Label lblMedicationStartDate;
        private System.Windows.Forms.Button btnPatientIDSelect;
        private System.Windows.Forms.TextBox txtPatientIDSelect;
        private System.Windows.Forms.Label lblPatientIDSelect;
    }
}