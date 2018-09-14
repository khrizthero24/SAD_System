namespace ELS
{
    partial class AddItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.TextBox();
            this.item_description = new System.Windows.Forms.TextBox();
            this.item_quantity = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.item_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Description :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(27, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Quantity :";
            // 
            // item_name
            // 
            this.item_name.Location = new System.Drawing.Point(608, 21);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(353, 33);
            this.item_name.TabIndex = 5;
            // 
            // item_description
            // 
            this.item_description.Location = new System.Drawing.Point(654, 74);
            this.item_description.Multiline = true;
            this.item_description.Name = "item_description";
            this.item_description.Size = new System.Drawing.Size(307, 134);
            this.item_description.TabIndex = 6;
            // 
            // item_quantity
            // 
            this.item_quantity.Location = new System.Drawing.Point(631, 227);
            this.item_quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(120, 33);
            this.item_quantity.TabIndex = 7;
            this.item_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(488, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(430, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // item_pic
            // 
            this.item_pic.BackgroundImage = global::ELS.Properties.Resources._default;
            this.item_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.item_pic.Location = new System.Drawing.Point(27, 24);
            this.item_pic.Name = "item_pic";
            this.item_pic.Size = new System.Drawing.Size(430, 265);
            this.item_pic.TabIndex = 2;
            this.item_pic.TabStop = false;
            this.item_pic.BackgroundImageChanged += new System.EventHandler(this.item_pic_BackgroundImageChanged);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.item_quantity);
            this.Controls.Add(this.item_description);
            this.Controls.Add(this.item_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.item_pic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddItem";
            this.Size = new System.Drawing.Size(964, 348);
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox item_pic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox item_name;
        private System.Windows.Forms.TextBox item_description;
        private System.Windows.Forms.NumericUpDown item_quantity;
        private System.Windows.Forms.Button button2;
    }
}
