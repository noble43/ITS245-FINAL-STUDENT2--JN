namespace DataAdapterEx.Views
{
    partial class MedicationHistory
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
            this.dgvMedication = new System.Windows.Forms.DataGridView();
            this.lblPatientHeader = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMedication = new System.Windows.Forms.Label();
            this.txtMedication = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.groupBoxMedication = new System.Windows.Forms.GroupBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.txtHCP = new System.Windows.Forms.TextBox();
            this.lblHCP = new System.Windows.Forms.Label();
            this.btnPatientIDSelect = new System.Windows.Forms.Button();
            this.txtPatientIDSelect = new System.Windows.Forms.TextBox();
            this.lblPatientIDSelect = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelectPatient = new System.Windows.Forms.Button();
            this.btnDemographics = new System.Windows.Forms.Button();
            this.btnImmunizations = new System.Windows.Forms.Button();
            this.btnGenMedHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedication)).BeginInit();
            this.groupBoxMedication.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedication
            // 
            this.dgvMedication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedication.Location = new System.Drawing.Point(12, 43);
            this.dgvMedication.Name = "dgvMedication";
            this.dgvMedication.Size = new System.Drawing.Size(157, 246);
            this.dgvMedication.TabIndex = 0;
            this.dgvMedication.SelectionChanged += new System.EventHandler(this.dgvMedication_SelectionChanged);
            // 
            // lblPatientHeader
            // 
            this.lblPatientHeader.BackColor = System.Drawing.Color.LightYellow;
            this.lblPatientHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatientHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPatientHeader.Location = new System.Drawing.Point(0, 0);
            this.lblPatientHeader.Name = "lblPatientHeader";
            this.lblPatientHeader.Size = new System.Drawing.Size(683, 40);
            this.lblPatientHeader.TabIndex = 1;
            this.lblPatientHeader.Text = "Patient Name | Age: XX";
            this.lblPatientHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(26, 136);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 40;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(26, 110);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 39;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(266, 25);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(61, 13);
            this.lblInstructions.TabIndex = 38;
            this.lblInstructions.Text = "Instructions";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(26, 84);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 13);
            this.lblUnit.TabIndex = 37;
            this.lblUnit.Text = "Unit";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(26, 58);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 36;
            this.lblAmount.Text = "Amount";
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Location = new System.Drawing.Point(26, 32);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(59, 13);
            this.lblMedication.TabIndex = 35;
            this.lblMedication.Text = "Medication";
            // 
            // txtMedication
            // 
            this.txtMedication.Location = new System.Drawing.Point(103, 29);
            this.txtMedication.Name = "txtMedication";
            this.txtMedication.Size = new System.Drawing.Size(113, 20);
            this.txtMedication.TabIndex = 29;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(87, 55);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(113, 20);
            this.txtAmount.TabIndex = 30;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(87, 81);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(113, 20);
            this.txtUnit.TabIndex = 31;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(103, 107);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(113, 20);
            this.txtStartDate.TabIndex = 33;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(103, 133);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(113, 20);
            this.txtEndDate.TabIndex = 34;
            // 
            // groupBoxMedication
            // 
            this.groupBoxMedication.Controls.Add(this.txtInstructions);
            this.groupBoxMedication.Controls.Add(this.txtHCP);
            this.groupBoxMedication.Controls.Add(this.lblHCP);
            this.groupBoxMedication.Controls.Add(this.txtUnit);
            this.groupBoxMedication.Controls.Add(this.lblEndDate);
            this.groupBoxMedication.Controls.Add(this.txtEndDate);
            this.groupBoxMedication.Controls.Add(this.lblStartDate);
            this.groupBoxMedication.Controls.Add(this.txtStartDate);
            this.groupBoxMedication.Controls.Add(this.lblInstructions);
            this.groupBoxMedication.Controls.Add(this.lblUnit);
            this.groupBoxMedication.Controls.Add(this.txtAmount);
            this.groupBoxMedication.Controls.Add(this.lblAmount);
            this.groupBoxMedication.Controls.Add(this.txtMedication);
            this.groupBoxMedication.Controls.Add(this.lblMedication);
            this.groupBoxMedication.Location = new System.Drawing.Point(175, 43);
            this.groupBoxMedication.Name = "groupBoxMedication";
            this.groupBoxMedication.Size = new System.Drawing.Size(503, 246);
            this.groupBoxMedication.TabIndex = 41;
            this.groupBoxMedication.TabStop = false;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(269, 51);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(228, 81);
            this.txtInstructions.TabIndex = 43;
            // 
            // txtHCP
            // 
            this.txtHCP.Location = new System.Drawing.Point(124, 159);
            this.txtHCP.Name = "txtHCP";
            this.txtHCP.Size = new System.Drawing.Size(113, 20);
            this.txtHCP.TabIndex = 42;
            // 
            // lblHCP
            // 
            this.lblHCP.AutoSize = true;
            this.lblHCP.Location = new System.Drawing.Point(26, 162);
            this.lblHCP.Name = "lblHCP";
            this.lblHCP.Size = new System.Drawing.Size(87, 13);
            this.lblHCP.TabIndex = 41;
            this.lblHCP.Text = "Prescription HCP";
            // 
            // btnPatientIDSelect
            // 
            this.btnPatientIDSelect.BackColor = System.Drawing.Color.Azure;
            this.btnPatientIDSelect.Location = new System.Drawing.Point(175, 341);
            this.btnPatientIDSelect.Name = "btnPatientIDSelect";
            this.btnPatientIDSelect.Size = new System.Drawing.Size(75, 23);
            this.btnPatientIDSelect.TabIndex = 56;
            this.btnPatientIDSelect.Text = "Load Patient";
            this.btnPatientIDSelect.UseVisualStyleBackColor = false;
            this.btnPatientIDSelect.Click += new System.EventHandler(this.btnPatientIDSelect_Click);
            // 
            // txtPatientIDSelect
            // 
            this.txtPatientIDSelect.Location = new System.Drawing.Point(104, 343);
            this.txtPatientIDSelect.Name = "txtPatientIDSelect";
            this.txtPatientIDSelect.Size = new System.Drawing.Size(58, 20);
            this.txtPatientIDSelect.TabIndex = 54;
            // 
            // lblPatientIDSelect
            // 
            this.lblPatientIDSelect.AutoSize = true;
            this.lblPatientIDSelect.Location = new System.Drawing.Point(11, 346);
            this.lblPatientIDSelect.Name = "lblPatientIDSelect";
            this.lblPatientIDSelect.Size = new System.Drawing.Size(87, 13);
            this.lblPatientIDSelect.TabIndex = 55;
            this.lblPatientIDSelect.Text = "Patient ID Select";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Azure;
            this.btnAdd.Location = new System.Drawing.Point(13, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Azure;
            this.btnModify.Location = new System.Drawing.Point(94, 306);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 46;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Azure;
            this.btnSave.Location = new System.Drawing.Point(175, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Azure;
            this.btnUndo.Location = new System.Drawing.Point(256, 306);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 48;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Azure;
            this.btnDelete.Location = new System.Drawing.Point(337, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelectPatient
            // 
            this.btnSelectPatient.BackColor = System.Drawing.Color.Azure;
            this.btnSelectPatient.Location = new System.Drawing.Point(426, 306);
            this.btnSelectPatient.Name = "btnSelectPatient";
            this.btnSelectPatient.Size = new System.Drawing.Size(123, 23);
            this.btnSelectPatient.TabIndex = 50;
            this.btnSelectPatient.Text = "Select Patient";
            this.btnSelectPatient.UseVisualStyleBackColor = false;
            this.btnSelectPatient.Click += new System.EventHandler(this.btnSelectPatient_Click);
            // 
            // btnDemographics
            // 
            this.btnDemographics.BackColor = System.Drawing.Color.Azure;
            this.btnDemographics.Location = new System.Drawing.Point(426, 336);
            this.btnDemographics.Name = "btnDemographics";
            this.btnDemographics.Size = new System.Drawing.Size(123, 23);
            this.btnDemographics.TabIndex = 51;
            this.btnDemographics.Text = "Patient Demographics";
            this.btnDemographics.UseVisualStyleBackColor = false;
            this.btnDemographics.Click += new System.EventHandler(this.btnDemographics_Click);
            // 
            // btnImmunizations
            // 
            this.btnImmunizations.BackColor = System.Drawing.Color.Azure;
            this.btnImmunizations.Location = new System.Drawing.Point(555, 306);
            this.btnImmunizations.Name = "btnImmunizations";
            this.btnImmunizations.Size = new System.Drawing.Size(123, 23);
            this.btnImmunizations.TabIndex = 52;
            this.btnImmunizations.Text = "Immunization History";
            this.btnImmunizations.UseVisualStyleBackColor = false;
            this.btnImmunizations.Click += new System.EventHandler(this.btnImmunizations_Click);
            // 
            // btnGenMedHistory
            // 
            this.btnGenMedHistory.BackColor = System.Drawing.Color.Azure;
            this.btnGenMedHistory.Location = new System.Drawing.Point(555, 336);
            this.btnGenMedHistory.Name = "btnGenMedHistory";
            this.btnGenMedHistory.Size = new System.Drawing.Size(123, 23);
            this.btnGenMedHistory.TabIndex = 53;
            this.btnGenMedHistory.Text = "Medical History";
            this.btnGenMedHistory.UseVisualStyleBackColor = false;
            this.btnGenMedHistory.Click += new System.EventHandler(this.btnGenMedHistory_Click);
            // 
            // MedicationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(683, 364);
            this.Controls.Add(this.btnPatientIDSelect);
            this.Controls.Add(this.txtPatientIDSelect);
            this.Controls.Add(this.lblPatientIDSelect);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelectPatient);
            this.Controls.Add(this.btnDemographics);
            this.Controls.Add(this.btnImmunizations);
            this.Controls.Add(this.btnGenMedHistory);
            this.Controls.Add(this.groupBoxMedication);
            this.Controls.Add(this.lblPatientHeader);
            this.Controls.Add(this.dgvMedication);
            this.Name = "MedicationHistory";
            this.Text = "Medication History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedication)).EndInit();
            this.groupBoxMedication.ResumeLayout(false);
            this.groupBoxMedication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedication;
        private System.Windows.Forms.Label lblPatientHeader;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.GroupBox groupBoxMedication;
        private System.Windows.Forms.TextBox txtHCP;
        private System.Windows.Forms.Label lblHCP;
        private System.Windows.Forms.Button btnPatientIDSelect;
        private System.Windows.Forms.TextBox txtPatientIDSelect;
        private System.Windows.Forms.Label lblPatientIDSelect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelectPatient;
        private System.Windows.Forms.Button btnDemographics;
        private System.Windows.Forms.Button btnImmunizations;
        private System.Windows.Forms.Button btnGenMedHistory;
        private System.Windows.Forms.TextBox txtInstructions;
    }
}