namespace DataAdapterEx.Views
{
    partial class GeneralMedicationHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstMedications;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtPrescriptionHCP;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelectPatient;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstMedications = new System.Windows.Forms.ListBox();
            this.txtMedication = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtPrescriptionHCP = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelectPatient = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lstMedications
            this.lstMedications.FormattingEnabled = true;
            this.lstMedications.ItemHeight = 16;
            this.lstMedications.Location = new System.Drawing.Point(20, 60);
            this.lstMedications.Size = new System.Drawing.Size(200, 340);
            this.lstMedications.SelectedIndexChanged += new System.EventHandler(this.lstMedications_SelectedIndexChanged);

            // Textboxes
            this.txtMedication.Location = new System.Drawing.Point(250, 60);
            this.txtMedication.Size = new System.Drawing.Size(200, 22);
            this.txtMedication.Text = "Medication";

            this.txtAmount.Location = new System.Drawing.Point(250, 100);
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.Text = "Amount";

            this.txtUnit.Location = new System.Drawing.Point(370, 100);
            this.txtUnit.Size = new System.Drawing.Size(80, 22);
            this.txtUnit.Text = "Unit";

            this.txtInstructions.Location = new System.Drawing.Point(250, 140);
            this.txtInstructions.Size = new System.Drawing.Size(200, 22);
            this.txtInstructions.Text = "Instructions";

            this.txtStartDate.Location = new System.Drawing.Point(250, 180);
            this.txtStartDate.Size = new System.Drawing.Size(100, 22);
            this.txtStartDate.Text = "Start Date";

            this.txtEndDate.Location = new System.Drawing.Point(370, 180);
            this.txtEndDate.Size = new System.Drawing.Size(100, 22);
            this.txtEndDate.Text = "End Date";

            this.txtPrescriptionHCP.Location = new System.Drawing.Point(250, 220);
            this.txtPrescriptionHCP.Size = new System.Drawing.Size(200, 22);
            this.txtPrescriptionHCP.Text = "Prescription HCP";

            // Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(250, 270);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnModify.Text = "Modify";
            this.btnModify.Location = new System.Drawing.Point(330, 270);
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(410, 270);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnUndo.Text = "Undo";
            this.btnUndo.Location = new System.Drawing.Point(490, 270);
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(570, 270);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnSelectPatient.Text = "Select Patient";
            this.btnSelectPatient.Location = new System.Drawing.Point(20, 20);
            this.btnSelectPatient.Click += new System.EventHandler(this.btnSelectPatient_Click);

            // Form
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.lstMedications);
            this.Controls.Add(this.txtMedication);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtPrescriptionHCP);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelectPatient);

            this.Text = "Medication History";
            this.Load += new System.EventHandler(this.GeneralMedicationHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
