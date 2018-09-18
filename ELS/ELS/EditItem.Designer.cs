namespace ELS
{
    partial class Edit_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.item_pic = new System.Windows.Forms.PictureBox();
            this.item_quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.item_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.item_pic);
            this.groupBox1.Controls.Add(this.item_quantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.item_description);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.item_name);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Item";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(473, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(430, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Edit Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // item_pic
            // 
            this.item_pic.BackgroundImage = global::ELS.Properties.Resources._default;
            this.item_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.item_pic.Location = new System.Drawing.Point(12, 26);
            this.item_pic.Name = "item_pic";
            this.item_pic.Size = new System.Drawing.Size(430, 265);
            this.item_pic.TabIndex = 11;
            this.item_pic.TabStop = false;
            this.item_pic.BackgroundImageChanged += new System.EventHandler(this.item_pic_BackgroundImageChanged);
            // 
            // item_quantity
            // 
            this.item_quantity.Enabled = false;
            this.item_quantity.Location = new System.Drawing.Point(616, 229);
            this.item_quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(120, 33);
            this.item_quantity.TabIndex = 16;
            this.item_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item Name :";
            // 
            // item_description
            // 
            this.item_description.Enabled = false;
            this.item_description.Location = new System.Drawing.Point(639, 76);
            this.item_description.Multiline = true;
            this.item_description.Name = "item_description";
            this.item_description.Size = new System.Drawing.Size(307, 134);
            this.item_description.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Description :";
            // 
            // item_name
            // 
            this.item_name.Enabled = false;
            this.item_name.Location = new System.Drawing.Point(593, 23);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(353, 33);
            this.item_name.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Edit Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Item Quantity :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Edit_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Edit_Item";
            this.Size = new System.Drawing.Size(964, 348);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.NumericUpDown item_quantity;
        public System.Windows.Forms.TextBox item_description;
        public System.Windows.Forms.TextBox item_name;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox item_pic;
    }
}
