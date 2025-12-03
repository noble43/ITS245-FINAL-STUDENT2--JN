namespace DataAdapterEx.Views
{
    partial class PatientReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        /// <param name="disposing"></param>
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
        /// Designer code
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_TitleHeader = new System.Windows.Forms.Label();
            this.lbl_PatientIDLabel = new System.Windows.Forms.Label();
            this.lbl_PatientID = new System.Windows.Forms.Label();
            this.btn_GenerateReport = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TitleHeader
            // 
            this.lbl_TitleHeader.BackColor = System.Drawing.Color.Gold;
            this.lbl_TitleHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleHeader.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitleHeader.Name = "lbl_TitleHeader";
            this.lbl_TitleHeader.Size = new System.Drawing.Size(800, 50);
            this.lbl_TitleHeader.TabIndex = 0;
            this.lbl_TitleHeader.Text = "Patient Report";
            this.lbl_TitleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PatientIDLabel
            // 
            this.lbl_PatientIDLabel.AutoSize = true;
            this.lbl_PatientIDLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_PatientIDLabel.Location = new System.Drawing.Point(30, 80);
            this.lbl_PatientIDLabel.Name = "lbl_PatientIDLabel";
            this.lbl_PatientIDLabel.Size = new System.Drawing.Size(88, 20);
            this.lbl_PatientIDLabel.TabIndex = 1;
            this.lbl_PatientIDLabel.Text = "Patient ID:";
            // 
            // lbl_PatientID
            // 
            this.lbl_PatientID.AutoSize = true;
            this.lbl_PatientID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_PatientID.Location = new System.Drawing.Point(124, 80);
            this.lbl_PatientID.Name = "lbl_PatientID";
            this.lbl_PatientID.Size = new System.Drawing.Size(38, 20);
            this.lbl_PatientID.TabIndex = 2;
            this.lbl_PatientID.Text = "000";
            // 
            // btn_GenerateReport
            // 
            this.btn_GenerateReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_GenerateReport.Location = new System.Drawing.Point(30, 140);
            this.btn_GenerateReport.Name = "btn_GenerateReport";
            this.btn_GenerateReport.Size = new System.Drawing.Size(200, 45);
            this.btn_GenerateReport.TabIndex = 3;
            this.btn_GenerateReport.Text = "Generate Report";
            this.btn_GenerateReport.UseVisualStyleBackColor = true;
            this.btn_GenerateReport.Click += new System.EventHandler(this.btn_GenerateReport_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Close.Location = new System.Drawing.Point(680, 390);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(95, 32);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            //
            // PatientReport
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_GenerateReport);
            this.Controls.Add(this.lbl_PatientID);
            this.Controls.Add(this.lbl_PatientIDLabel);
            this.Controls.Add(this.lbl_TitleHeader);
            this.Name = "PatientReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Report";
            this.Load += new System.EventHandler(this.PatientReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TitleHeader;
        private System.Windows.Forms.Label lbl_PatientIDLabel;
        private System.Windows.Forms.Label lbl_PatientID;
        private System.Windows.Forms.Button btn_GenerateReport;
        private System.Windows.Forms.Button btn_Close;
    }
}
