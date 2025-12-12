namespace DataAdapterEx.Views
{
    partial class ImmunizationHistoryForm
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.lb_ImmunizationRecords = new System.Windows.Forms.ListBox();
            this.lbl_Vaccine = new System.Windows.Forms.Label();
            this.lbl_HcpID = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Expiration = new System.Windows.Forms.Label();
            this.lbl_Delivery = new System.Windows.Forms.Label();
            this.lbl_Comments = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_Vaccine = new System.Windows.Forms.TextBox();
            this.txt_HcpID = new System.Windows.Forms.TextBox();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.txt_Delivery = new System.Windows.Forms.TextBox();
            this.txt_Expiration = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_OpenPatientDemogrpahics = new System.Windows.Forms.Button();
            this.btn_OpenSelectPatient = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btnGenMedHistory = new System.Windows.Forms.Button();
            this.btnMedicationsHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(549, 403);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 35);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modify.Location = new System.Drawing.Point(142, 403);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(91, 35);
            this.btn_Modify.TabIndex = 4;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // lb_ImmunizationRecords
            // 
            this.lb_ImmunizationRecords.FormattingEnabled = true;
            this.lb_ImmunizationRecords.Location = new System.Drawing.Point(12, 108);
            this.lb_ImmunizationRecords.Name = "lb_ImmunizationRecords";
            this.lb_ImmunizationRecords.Size = new System.Drawing.Size(366, 277);
            this.lb_ImmunizationRecords.TabIndex = 5;
            this.lb_ImmunizationRecords.SelectedIndexChanged += new System.EventHandler(this.lb_ImmunizationRecords_SelectedIndexChanged);
            // 
            // lbl_Vaccine
            // 
            this.lbl_Vaccine.AutoSize = true;
            this.lbl_Vaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vaccine.Location = new System.Drawing.Point(407, 108);
            this.lbl_Vaccine.Name = "lbl_Vaccine";
            this.lbl_Vaccine.Size = new System.Drawing.Size(67, 16);
            this.lbl_Vaccine.TabIndex = 6;
            this.lbl_Vaccine.Text = "Vaccine:";
            // 
            // lbl_HcpID
            // 
            this.lbl_HcpID.AutoSize = true;
            this.lbl_HcpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HcpID.Location = new System.Drawing.Point(405, 369);
            this.lbl_HcpID.Name = "lbl_HcpID";
            this.lbl_HcpID.Size = new System.Drawing.Size(61, 16);
            this.lbl_HcpID.TabIndex = 7;
            this.lbl_HcpID.Text = "HCP ID:";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(407, 160);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(44, 16);
            this.lbl_Date.TabIndex = 8;
            this.lbl_Date.Text = "Date:";
            // 
            // lbl_Expiration
            // 
            this.lbl_Expiration.AutoSize = true;
            this.lbl_Expiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiration.Location = new System.Drawing.Point(407, 206);
            this.lbl_Expiration.Name = "lbl_Expiration";
            this.lbl_Expiration.Size = new System.Drawing.Size(80, 16);
            this.lbl_Expiration.TabIndex = 9;
            this.lbl_Expiration.Text = "Expiration:";
            // 
            // lbl_Delivery
            // 
            this.lbl_Delivery.AutoSize = true;
            this.lbl_Delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delivery.Location = new System.Drawing.Point(407, 262);
            this.lbl_Delivery.Name = "lbl_Delivery";
            this.lbl_Delivery.Size = new System.Drawing.Size(69, 16);
            this.lbl_Delivery.TabIndex = 10;
            this.lbl_Delivery.Text = "Delivery:";
            // 
            // lbl_Comments
            // 
            this.lbl_Comments.AutoSize = true;
            this.lbl_Comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comments.Location = new System.Drawing.Point(407, 315);
            this.lbl_Comments.Name = "lbl_Comments";
            this.lbl_Comments.Size = new System.Drawing.Size(83, 16);
            this.lbl_Comments.TabIndex = 11;
            this.lbl_Comments.Text = "Comments:";
            this.lbl_Comments.Click += new System.EventHandler(this.lbl_Comments_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(12, 403);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Add.Size = new System.Drawing.Size(91, 35);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Undo.Location = new System.Drawing.Point(408, 403);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Undo.Size = new System.Drawing.Size(91, 35);
            this.btn_Undo.TabIndex = 13;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(272, 403);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Save.Size = new System.Drawing.Size(91, 35);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(697, 403);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Close.Size = new System.Drawing.Size(91, 35);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_Vaccine
            // 
            this.txt_Vaccine.Location = new System.Drawing.Point(511, 104);
            this.txt_Vaccine.Name = "txt_Vaccine";
            this.txt_Vaccine.Size = new System.Drawing.Size(277, 20);
            this.txt_Vaccine.TabIndex = 16;
            // 
            // txt_HcpID
            // 
            this.txt_HcpID.Location = new System.Drawing.Point(511, 365);
            this.txt_HcpID.Name = "txt_HcpID";
            this.txt_HcpID.Size = new System.Drawing.Size(277, 20);
            this.txt_HcpID.TabIndex = 17;
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(511, 315);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(277, 20);
            this.txt_Comments.TabIndex = 18;
            // 
            // txt_Delivery
            // 
            this.txt_Delivery.Location = new System.Drawing.Point(511, 262);
            this.txt_Delivery.Name = "txt_Delivery";
            this.txt_Delivery.Size = new System.Drawing.Size(277, 20);
            this.txt_Delivery.TabIndex = 19;
            // 
            // txt_Expiration
            // 
            this.txt_Expiration.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Expiration.Location = new System.Drawing.Point(511, 206);
            this.txt_Expiration.Name = "txt_Expiration";
            this.txt_Expiration.Size = new System.Drawing.Size(277, 20);
            this.txt_Expiration.TabIndex = 20;
            this.txt_Expiration.Text = "(YYYY-MM-DD)";
            // 
            // txt_Date
            // 
            this.txt_Date.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Date.Location = new System.Drawing.Point(511, 160);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(277, 20);
            this.txt_Date.TabIndex = 21;
            this.txt_Date.Text = "(YYYY-MM-DD)";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(267, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(254, 29);
            this.lbl_Title.TabIndex = 22;
            this.lbl_Title.Text = "Immunization History";
            // 
            // btn_OpenPatientDemogrpahics
            // 
            this.btn_OpenPatientDemogrpahics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenPatientDemogrpahics.Location = new System.Drawing.Point(524, 52);
            this.btn_OpenPatientDemogrpahics.Name = "btn_OpenPatientDemogrpahics";
            this.btn_OpenPatientDemogrpahics.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_OpenPatientDemogrpahics.Size = new System.Drawing.Size(116, 35);
            this.btn_OpenPatientDemogrpahics.TabIndex = 23;
            this.btn_OpenPatientDemogrpahics.Text = "Patient Demographics";
            this.btn_OpenPatientDemogrpahics.UseVisualStyleBackColor = true;
            this.btn_OpenPatientDemogrpahics.Click += new System.EventHandler(this.btn_OpenPatientDemogrpahics_Click);
            // 
            // btn_OpenSelectPatient
            // 
            this.btn_OpenSelectPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenSelectPatient.Location = new System.Drawing.Point(662, 52);
            this.btn_OpenSelectPatient.Name = "btn_OpenSelectPatient";
            this.btn_OpenSelectPatient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_OpenSelectPatient.Size = new System.Drawing.Size(116, 35);
            this.btn_OpenSelectPatient.TabIndex = 24;
            this.btn_OpenSelectPatient.Text = "Select Patient";
            this.btn_OpenSelectPatient.UseVisualStyleBackColor = true;
            this.btn_OpenSelectPatient.Click += new System.EventHandler(this.btn_OpenSelectPatient_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(12, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(121, 29);
            this.lbl_Header.TabIndex = 31;
            this.lbl_Header.Text = "Patient Info";
            this.lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenMedHistory
            // 
            this.btnGenMedHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenMedHistory.Location = new System.Drawing.Point(262, 52);
            this.btnGenMedHistory.Name = "btnGenMedHistory";
            this.btnGenMedHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGenMedHistory.Size = new System.Drawing.Size(116, 35);
            this.btnGenMedHistory.TabIndex = 32;
            this.btnGenMedHistory.Text = "Medical History";
            this.btnGenMedHistory.UseVisualStyleBackColor = true;
            this.btnGenMedHistory.Click += new System.EventHandler(this.btn_btnGenMedHistory_Click);
            // 
            // btnMedicationsHistory
            // 
            this.btnMedicationsHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicationsHistory.Location = new System.Drawing.Point(393, 52);
            this.btnMedicationsHistory.Name = "btnMedicationsHistory";
            this.btnMedicationsHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMedicationsHistory.Size = new System.Drawing.Size(116, 35);
            this.btnMedicationsHistory.TabIndex = 33;
            this.btnMedicationsHistory.Text = "Medication History";
            this.btnMedicationsHistory.UseVisualStyleBackColor = true;
            this.btnMedicationsHistory.Click += new System.EventHandler(this.btn_Medications_Click);
            // 
            // ImmunizationHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMedicationsHistory);
            this.Controls.Add(this.btnGenMedHistory);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.btn_OpenSelectPatient);
            this.Controls.Add(this.btn_OpenPatientDemogrpahics);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_Expiration);
            this.Controls.Add(this.txt_Delivery);
            this.Controls.Add(this.txt_Comments);
            this.Controls.Add(this.txt_HcpID);
            this.Controls.Add(this.txt_Vaccine);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Comments);
            this.Controls.Add(this.lbl_Delivery);
            this.Controls.Add(this.lbl_Expiration);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_HcpID);
            this.Controls.Add(this.lbl_Vaccine);
            this.Controls.Add(this.lb_ImmunizationRecords);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Delete);
            this.Name = "ImmunizationHistoryForm";
            this.Text = "ImmunizationHistoryForm";
            this.Load += new System.EventHandler(this.ImmunizationHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.ListBox lb_ImmunizationRecords;
        private System.Windows.Forms.Label lbl_Vaccine;
        private System.Windows.Forms.Label lbl_HcpID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Expiration;
        private System.Windows.Forms.Label lbl_Delivery;
        private System.Windows.Forms.Label lbl_Comments;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox txt_Vaccine;
        private System.Windows.Forms.TextBox txt_HcpID;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.TextBox txt_Delivery;
        private System.Windows.Forms.TextBox txt_Expiration;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_OpenPatientDemogrpahics;
        private System.Windows.Forms.Button btn_OpenSelectPatient;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btnGenMedHistory;
        private System.Windows.Forms.Button btnMedicationsHistory;
    }
}