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
            this.cpEControl1 = new ELS.CpEControl();
            this.SuspendLayout();
            // 
            // cpEControl1
            // 
            this.cpEControl1.BackColor = System.Drawing.Color.Transparent;
            this.cpEControl1.borrow = null;
            this.cpEControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpEControl1.ForeColor = System.Drawing.Color.White;
            this.cpEControl1.Location = new System.Drawing.Point(90, 14);
            this.cpEControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpEControl1.Name = "cpEControl1";
            this.cpEControl1.Size = new System.Drawing.Size(844, 756);
            this.cpEControl1.TabIndex = 0;
            // 
            // BorrowerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.cpEControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "BorrowerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowerMainForm";
            this.Load += new System.EventHandler(this.BorrowerMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CpEControl cpEControl1;
    }
}