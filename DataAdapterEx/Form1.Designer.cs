namespace DataAdapterEx
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_RetrievePatients = new System.Windows.Forms.Button();
            this.lbl_PID = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.btn_ShowGlobalPID = new System.Windows.Forms.Button();
            this.lbl_GlobalPID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PtDemog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(497, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btn_RetrievePatients
            // 
            this.btn_RetrievePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RetrievePatients.Location = new System.Drawing.Point(50, 287);
            this.btn_RetrievePatients.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RetrievePatients.Name = "btn_RetrievePatients";
            this.btn_RetrievePatients.Size = new System.Drawing.Size(262, 43);
            this.btn_RetrievePatients.TabIndex = 1;
            this.btn_RetrievePatients.Text = "Retrieve All Patients";
            this.btn_RetrievePatients.UseMnemonic = false;
            this.btn_RetrievePatients.UseVisualStyleBackColor = true;
            this.btn_RetrievePatients.Click += new System.EventHandler(this.btn_RetrievePatients_Click);
            // 
            // lbl_PID
            // 
            this.lbl_PID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PID.Location = new System.Drawing.Point(458, 287);
            this.lbl_PID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PID.Name = "lbl_PID";
            this.lbl_PID.Size = new System.Drawing.Size(90, 26);
            this.lbl_PID.TabIndex = 2;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_lastName.Location = new System.Drawing.Point(458, 327);
            this.lbl_lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(90, 22);
            this.lbl_lastName.TabIndex = 3;
            // 
            // btn_ShowGlobalPID
            // 
            this.btn_ShowGlobalPID.Location = new System.Drawing.Point(50, 338);
            this.btn_ShowGlobalPID.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ShowGlobalPID.Name = "btn_ShowGlobalPID";
            this.btn_ShowGlobalPID.Size = new System.Drawing.Size(262, 33);
            this.btn_ShowGlobalPID.TabIndex = 4;
            this.btn_ShowGlobalPID.Text = "Show Global PID";
            this.btn_ShowGlobalPID.UseVisualStyleBackColor = true;
            this.btn_ShowGlobalPID.Click += new System.EventHandler(this.btn_ShowGlobalPID_Click);
            // 
            // lbl_GlobalPID
            // 
            this.lbl_GlobalPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_GlobalPID.Location = new System.Drawing.Point(338, 350);
            this.lbl_GlobalPID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GlobalPID.Name = "lbl_GlobalPID";
            this.lbl_GlobalPID.Size = new System.Drawing.Size(55, 22);
            this.lbl_GlobalPID.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_PtDemog);
            this.panel1.Location = new System.Drawing.Point(580, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 313);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Patient Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_PtDemog
            // 
            this.btn_PtDemog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PtDemog.Location = new System.Drawing.Point(18, 35);
            this.btn_PtDemog.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PtDemog.Name = "btn_PtDemog";
            this.btn_PtDemog.Size = new System.Drawing.Size(125, 40);
            this.btn_PtDemog.TabIndex = 0;
            this.btn_PtDemog.Text = "Demographics";
            this.btn_PtDemog.UseVisualStyleBackColor = true;
            this.btn_PtDemog.Click += new System.EventHandler(this.btn_PtDemog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_GlobalPID);
            this.Controls.Add(this.btn_ShowGlobalPID);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_PID);
            this.Controls.Add(this.btn_RetrievePatients);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_RetrievePatients;
        private System.Windows.Forms.Label lbl_PID;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Button btn_ShowGlobalPID;
        private System.Windows.Forms.Label lbl_GlobalPID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_PtDemog;
        private System.Windows.Forms.Button button1;
    }
}

