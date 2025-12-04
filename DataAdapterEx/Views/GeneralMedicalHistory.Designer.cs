namespace DataAdapterEx.Views
{
    partial class GeneralMedicalHistory
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.txtBehavioral = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();

            // dgvHistory
            this.dgvHistory.Location = new System.Drawing.Point(12, 12);
            this.dgvHistory.Size = new System.Drawing.Size(500, 150);
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.SelectionChanged += new System.EventHandler(this.dgvHistory_SelectionChanged);

            // Labels
            this.label1.Text = "Marital Status";
            this.label1.Location = new System.Drawing.Point(12, 190);

            this.label2.Text = "Education";
            this.label2.Location = new System.Drawing.Point(12, 230);

            this.label3.Text = "Behavioral History";
            this.label3.Location = new System.Drawing.Point(12, 270);

            // TextBoxes
            this.txtMaritalStatus.Location = new System.Drawing.Point(140, 190);
            this.txtEducation.Location = new System.Drawing.Point(140, 230);
            this.txtBehavioral.Location = new System.Drawing.Point(140, 270);
            this.txtBehavioral.Multiline = true;
            this.txtBehavioral.Height = 60;

            // Buttons
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(12, 360);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(90, 360);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(170, 360);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnUndo.Text = "Undo";
            this.btnUndo.Location = new System.Drawing.Point(250, 360);
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(550, 420);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.txtMaritalStatus);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.txtBehavioral);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);

            this.Text = "General Medical History";
            this.Load += new System.EventHandler(this.GeneralMedicalHistory_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.TextBox txtBehavioral;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}