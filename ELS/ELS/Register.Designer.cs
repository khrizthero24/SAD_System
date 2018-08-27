namespace ELS
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.conpasstxt = new System.Windows.Forms.TextBox();
            this.idnumtxt = new System.Windows.Forms.TextBox();
            this.acctcmb = new System.Windows.Forms.ComboBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(49, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(49, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Account Type:";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(320, 57);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(398, 39);
            this.usertxt.TabIndex = 6;
            this.usertxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(320, 147);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(398, 39);
            this.passtxt.TabIndex = 7;
            // 
            // conpasstxt
            // 
            this.conpasstxt.Location = new System.Drawing.Point(320, 237);
            this.conpasstxt.Name = "conpasstxt";
            this.conpasstxt.Size = new System.Drawing.Size(398, 39);
            this.conpasstxt.TabIndex = 8;
            // 
            // idnumtxt
            // 
            this.idnumtxt.Location = new System.Drawing.Point(320, 327);
            this.idnumtxt.Name = "idnumtxt";
            this.idnumtxt.Size = new System.Drawing.Size(398, 39);
            this.idnumtxt.TabIndex = 9;
            // 
            // acctcmb
            // 
            this.acctcmb.FormattingEnabled = true;
            this.acctcmb.Items.AddRange(new object[] {
            "Toolkeeper",
            "Professor"});
            this.acctcmb.Location = new System.Drawing.Point(320, 416);
            this.acctcmb.Name = "acctcmb";
            this.acctcmb.Size = new System.Drawing.Size(398, 40);
            this.acctcmb.TabIndex = 10;
            // 
            // registerbtn
            // 
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.Image = global::ELS.Properties.Resources.Registration_64px;
            this.registerbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerbtn.Location = new System.Drawing.Point(301, 505);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(174, 65);
            this.registerbtn.TabIndex = 11;
            this.registerbtn.Text = "Register";
            this.registerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.registerbtn);
            this.groupBox1.Controls.Add(this.acctcmb);
            this.groupBox1.Controls.Add(this.idnumtxt);
            this.groupBox1.Controls.Add(this.conpasstxt);
            this.groupBox1.Controls.Add(this.passtxt);
            this.groupBox1.Controls.Add(this.usertxt);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 576);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Account";
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::ELS.Properties.Resources.Registration_64px;
            this.exitButton.Location = new System.Drawing.Point(544, 505);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(174, 65);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ELS.Properties.Resources.modern_material_design_full_hd_wallpaper_no_766_1920x1920;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox conpasstxt;
        private System.Windows.Forms.TextBox idnumtxt;
        private System.Windows.Forms.ComboBox acctcmb;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButton;
    }
}