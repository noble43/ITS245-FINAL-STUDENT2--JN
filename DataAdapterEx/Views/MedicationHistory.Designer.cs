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

            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            this.SuspendLayout();

            // dgvMedications
            this.dgvMedications.Location = new System.Drawing.Point(12, 12);
            this.dgvMedications.Size = new System.Drawing.Size(450, 150);
            this.dgvMedications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedications.MultiSelect = false;
            this.dgvMedications.SelectionChanged += new System.EventHandler(this.dgvMedications_SelectionChanged);

            // Labels
            this.label1.Text = "Medication";
            this.label1.Location = new System.Drawing.Point(12, 180);

            this.label2.Text = "Amount";
            this.label2.Location = new System.Drawing.Point(12, 220);

            this.label3.Text = "Unit";
            this.label3.Location = new System.Drawing.Point(12, 260);

            this.label4.Text = "Instructions";
            this.label4.Location = new System.Drawing.Point(12, 300);

            // TextBoxes
            this.txtMedication.Location = new System.Drawing.Point(120, 180);
            this.txtAmount.Location = new System.Drawing.Point(120, 220);
            this.txtUnit.Location = new System.Drawing.Point(120, 260);
            this.txtInstructions.Location = new System.Drawing.Point(120, 300);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Height = 60;

            // Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(12, 380);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(90, 380);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(170, 380);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnUndo.Text = "Undo";
            this.btnUndo.Location = new System.Drawing.Point(250, 380);
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.Controls.Add(this.dgvMedications);
            this.Controls.Add(this.txtMedication);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);

            this.Text = "Medication History";
            this.Load += new System.EventHandler(this.MedicationHistoryForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}