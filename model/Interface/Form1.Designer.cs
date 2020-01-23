namespace Interface
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbPreference = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.txbWaste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbWaste = new System.Windows.Forms.ComboBox();
            this.cmbRecycle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.Menu;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(96, 52);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 29);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(96, 100);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(59, 29);
            this.lbAge.TabIndex = 1;
            this.lbAge.Text = "Age";
            this.lbAge.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbPreference
            // 
            this.lbPreference.AutoSize = true;
            this.lbPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreference.Location = new System.Drawing.Point(88, 156);
            this.lbPreference.Name = "lbPreference";
            this.lbPreference.Size = new System.Drawing.Size(85, 29);
            this.lbPreference.TabIndex = 2;
            this.lbPreference.Text = "Waste";
            this.lbPreference.Click += new System.EventHandler(this.lbPreference_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(240, 52);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(119, 22);
            this.txbName.TabIndex = 3;
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(240, 100);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(119, 22);
            this.txbAge.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(244, 303);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 42);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(76, 304);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(115, 41);
            this.btShow.TabIndex = 8;
            this.btShow.Text = "Show List";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // txbWaste
            // 
            this.txbWaste.Location = new System.Drawing.Point(244, 209);
            this.txbWaste.Name = "txbWaste";
            this.txbWaste.Size = new System.Drawing.Size(115, 22);
            this.txbWaste.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount of Waste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Do you recycle?";
            // 
            // cmbWaste
            // 
            this.cmbWaste.FormattingEnabled = true;
            this.cmbWaste.Items.AddRange(new object[] {
            "Natural",
            "Plastic",
            "Glass"});
            this.cmbWaste.Location = new System.Drawing.Point(240, 156);
            this.cmbWaste.Name = "cmbWaste";
            this.cmbWaste.Size = new System.Drawing.Size(121, 24);
            this.cmbWaste.TabIndex = 12;
            this.cmbWaste.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbRecycle
            // 
            this.cmbRecycle.FormattingEnabled = true;
            this.cmbRecycle.Items.AddRange(new object[] {
            "Yes",
            "No",
            ""});
            this.cmbRecycle.Location = new System.Drawing.Point(240, 254);
            this.cmbRecycle.Name = "cmbRecycle";
            this.cmbRecycle.Size = new System.Drawing.Size(121, 24);
            this.cmbRecycle.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 435);
            this.Controls.Add(this.cmbRecycle);
            this.Controls.Add(this.cmbWaste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbWaste);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txbAge);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lbPreference);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbPreference;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAge;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.TextBox txbWaste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbWaste;
        private System.Windows.Forms.ComboBox cmbRecycle;
    }
}

