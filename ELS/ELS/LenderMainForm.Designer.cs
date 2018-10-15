namespace ELS
{
    partial class LenderMainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addItem1 = new ELS.AddItem();
            this.queue_list1 = new ELS.queue_list();
            this.edit_Item1 = new ELS.Edit_Item();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.item_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 744);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::ELS.Properties.Resources.Sync_32px;
            this.button4.Location = new System.Drawing.Point(793, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 52);
            this.button4.TabIndex = 6;
            this.button4.Text = "Refresh List";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addItem1);
            this.panel1.Controls.Add(this.queue_list1);
            this.panel1.Controls.Add(this.edit_Item1);
            this.panel1.Location = new System.Drawing.Point(18, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 348);
            this.panel1.TabIndex = 4;
            // 
            // addItem1
            // 
            this.addItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem1.Location = new System.Drawing.Point(0, 0);
            this.addItem1.Margin = new System.Windows.Forms.Padding(6);
            this.addItem1.Name = "addItem1";
            this.addItem1.Size = new System.Drawing.Size(964, 348);
            this.addItem1.TabIndex = 3;
            this.addItem1.Visible = false;
            // 
            // queue_list1
            // 
            this.queue_list1.BackColor = System.Drawing.Color.Transparent;
            this.queue_list1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queue_list1.ForeColor = System.Drawing.Color.White;
            this.queue_list1.Location = new System.Drawing.Point(0, 0);
            this.queue_list1.Margin = new System.Windows.Forms.Padding(6);
            this.queue_list1.Name = "queue_list1";
            this.queue_list1.Size = new System.Drawing.Size(964, 348);
            this.queue_list1.TabIndex = 2;
            this.queue_list1.Visible = false;
            // 
            // edit_Item1
            // 
            this.edit_Item1.BackColor = System.Drawing.Color.White;
            this.edit_Item1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_Item1.Location = new System.Drawing.Point(0, 0);
            this.edit_Item1.Margin = new System.Windows.Forms.Padding(6);
            this.edit_Item1.Name = "edit_Item1";
            this.edit_Item1.Size = new System.Drawing.Size(964, 348);
            this.edit_Item1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item List";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_no,
            this.item_name,
            this.description,
            this.quantity});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(18, 79);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(964, 217);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // item_no
            // 
            this.item_no.Text = "Item Number";
            this.item_no.Width = 368;
            // 
            // item_name
            // 
            this.item_name.Text = "Item Name";
            this.item_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_name.Width = 196;
            // 
            // description
            // 
            this.description.Text = "Description";
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 199;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::ELS.Properties.Resources.Print_32px;
            this.button5.Location = new System.Drawing.Point(600, 302);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 52);
            this.button5.TabIndex = 7;
            this.button5.Text = "Print";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::ELS.Properties.Resources.Administrative_Tools_32px;
            this.button3.Location = new System.Drawing.Point(407, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Check Item Queue";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ELS.Properties.Resources.Edit_Property_32px;
            this.button2.Location = new System.Drawing.Point(214, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit Item";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ELS.Properties.Resources.Add_New_64px1;
            this.button1.Location = new System.Drawing.Point(21, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Item";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LenderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LenderMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LenderMainForm";
            this.Load += new System.EventHandler(this.LenderMainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LenderMainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader item_no;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader description;
        private Edit_Item edit_Item1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Button button4;
        private queue_list queue_list1;
        private AddItem addItem1;
        public System.Windows.Forms.Button button5;
    }
}