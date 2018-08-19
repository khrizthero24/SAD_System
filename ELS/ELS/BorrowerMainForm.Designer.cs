namespace ELS
{
    partial class BorrowerMainForm
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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.borrowerPanel = new System.Windows.Forms.Panel();
            this.cpEControl1 = new ELS.CpEControl();
            this.buttonPanel.SuspendLayout();
            this.borrowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonPanel.Controls.Add(this.selectPanel);
            this.buttonPanel.Controls.Add(this.button2);
            this.buttonPanel.Controls.Add(this.button1);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(7);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(200, 768);
            this.buttonPanel.TabIndex = 0;
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.White;
            this.selectPanel.Location = new System.Drawing.Point(185, 0);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(10, 384);
            this.selectPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ELS.Properties.Resources.Tick_Box_64px;
            this.button2.Location = new System.Drawing.Point(0, 384);
            this.button2.Margin = new System.Windows.Forms.Padding(7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 384);
            this.button2.TabIndex = 1;
            this.button2.Text = "ECE";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ELS.Properties.Resources.Tick_Box_64px;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 384);
            this.button1.TabIndex = 0;
            this.button1.Text = "CpE";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // borrowerPanel
            // 
            this.borrowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowerPanel.BackColor = System.Drawing.Color.Transparent;
            this.borrowerPanel.Controls.Add(this.cpEControl1);
            this.borrowerPanel.Location = new System.Drawing.Point(200, 12);
            this.borrowerPanel.Name = "borrowerPanel";
            this.borrowerPanel.Size = new System.Drawing.Size(824, 756);
            this.borrowerPanel.TabIndex = 2;
            // 
            // cpEControl1
            // 
            this.cpEControl1.BackColor = System.Drawing.Color.Transparent;
            this.cpEControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpEControl1.Location = new System.Drawing.Point(0, 0);
            this.cpEControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpEControl1.Name = "cpEControl1";
            this.cpEControl1.Size = new System.Drawing.Size(824, 756);
            this.cpEControl1.TabIndex = 0;
            // 
            // BorrowerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELS.Properties.Resources.modern_material_design_full_hd_wallpaper_no_766_1920x1920;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.borrowerPanel);
            this.Controls.Add(this.buttonPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "BorrowerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowerMainForm";
            this.Load += new System.EventHandler(this.BorrowerMainForm_Load);
            this.buttonPanel.ResumeLayout(false);
            this.borrowerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.Panel borrowerPanel;
        private CpEControl cpEControl1;
    }
}