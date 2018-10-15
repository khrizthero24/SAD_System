namespace ELS
{
    partial class LendReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.item_list_groupBox = new System.Windows.Forms.GroupBox();
            this.item_all_defects = new System.Windows.Forms.RadioButton();
            this.item_all_items = new System.Windows.Forms.RadioButton();
            this.queue_list_groupBox = new System.Windows.Forms.GroupBox();
            this.queue_not_returned = new System.Windows.Forms.RadioButton();
            this.queue_returned = new System.Windows.Forms.RadioButton();
            this.queue_listView = new System.Windows.Forms.ListView();
            this.item_listView = new System.Windows.Forms.ListView();
            this.queue_queue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queue_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queue_faculty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.defect_listView = new System.Windows.Forms.ListView();
            this.defect_item_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.defect_item_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.defect_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queue_room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queue_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.item_list_groupBox.SuspendLayout();
            this.queue_list_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.defect_listView);
            this.panel1.Controls.Add(this.queue_listView);
            this.panel1.Controls.Add(this.item_listView);
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(216, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 729);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(791, 729);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Queue List",
            "Item List"});
            this.comboBox1.Location = new System.Drawing.Point(12, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 40);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 143);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // item_list_groupBox
            // 
            this.item_list_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.item_list_groupBox.Controls.Add(this.item_all_defects);
            this.item_list_groupBox.Controls.Add(this.item_all_items);
            this.item_list_groupBox.ForeColor = System.Drawing.Color.White;
            this.item_list_groupBox.Location = new System.Drawing.Point(12, 260);
            this.item_list_groupBox.Name = "item_list_groupBox";
            this.item_list_groupBox.Size = new System.Drawing.Size(192, 239);
            this.item_list_groupBox.TabIndex = 6;
            this.item_list_groupBox.TabStop = false;
            this.item_list_groupBox.Text = "Parameters";
            // 
            // item_all_defects
            // 
            this.item_all_defects.AutoSize = true;
            this.item_all_defects.Location = new System.Drawing.Point(13, 137);
            this.item_all_defects.Name = "item_all_defects";
            this.item_all_defects.Size = new System.Drawing.Size(173, 36);
            this.item_all_defects.TabIndex = 1;
            this.item_all_defects.Text = "With Defects";
            this.item_all_defects.UseVisualStyleBackColor = true;
            // 
            // item_all_items
            // 
            this.item_all_items.AutoSize = true;
            this.item_all_items.Location = new System.Drawing.Point(13, 61);
            this.item_all_items.Name = "item_all_items";
            this.item_all_items.Size = new System.Drawing.Size(128, 36);
            this.item_all_items.TabIndex = 0;
            this.item_all_items.Text = "All Items";
            this.item_all_items.UseVisualStyleBackColor = true;
            // 
            // queue_list_groupBox
            // 
            this.queue_list_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.queue_list_groupBox.Controls.Add(this.queue_not_returned);
            this.queue_list_groupBox.Controls.Add(this.queue_returned);
            this.queue_list_groupBox.ForeColor = System.Drawing.Color.White;
            this.queue_list_groupBox.Location = new System.Drawing.Point(12, 260);
            this.queue_list_groupBox.Name = "queue_list_groupBox";
            this.queue_list_groupBox.Size = new System.Drawing.Size(192, 239);
            this.queue_list_groupBox.TabIndex = 9;
            this.queue_list_groupBox.TabStop = false;
            this.queue_list_groupBox.Text = "Parameters";
            // 
            // queue_not_returned
            // 
            this.queue_not_returned.AutoSize = true;
            this.queue_not_returned.Location = new System.Drawing.Point(13, 137);
            this.queue_not_returned.Name = "queue_not_returned";
            this.queue_not_returned.Size = new System.Drawing.Size(181, 36);
            this.queue_not_returned.TabIndex = 1;
            this.queue_not_returned.Text = "Not Returned";
            this.queue_not_returned.UseVisualStyleBackColor = true;
            // 
            // queue_returned
            // 
            this.queue_returned.AutoSize = true;
            this.queue_returned.Location = new System.Drawing.Point(13, 61);
            this.queue_returned.Name = "queue_returned";
            this.queue_returned.Size = new System.Drawing.Size(133, 36);
            this.queue_returned.TabIndex = 0;
            this.queue_returned.Text = "Returned";
            this.queue_returned.UseVisualStyleBackColor = true;
            // 
            // queue_listView
            // 
            this.queue_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.queue_queue,
            this.queue_name,
            this.queue_faculty,
            this.queue_room,
            this.queue_time});
            this.queue_listView.Location = new System.Drawing.Point(3, 33);
            this.queue_listView.Name = "queue_listView";
            this.queue_listView.Size = new System.Drawing.Size(121, 97);
            this.queue_listView.TabIndex = 10;
            this.queue_listView.UseCompatibleStateImageBehavior = false;
            this.queue_listView.Visible = false;
            this.queue_listView.SelectedIndexChanged += new System.EventHandler(this.queue_listView_SelectedIndexChanged);
            // 
            // item_listView
            // 
            this.item_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemno,
            this.name,
            this.description,
            this.quantity});
            this.item_listView.Location = new System.Drawing.Point(130, 33);
            this.item_listView.Name = "item_listView";
            this.item_listView.Size = new System.Drawing.Size(121, 97);
            this.item_listView.TabIndex = 11;
            this.item_listView.UseCompatibleStateImageBehavior = false;
            this.item_listView.Visible = false;
            this.item_listView.SelectedIndexChanged += new System.EventHandler(this.item_listView_SelectedIndexChanged);
            // 
            // defect_listView
            // 
            this.defect_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.defect_item_no,
            this.defect_item_name,
            this.defect_quantity});
            this.defect_listView.Location = new System.Drawing.Point(257, 33);
            this.defect_listView.Name = "defect_listView";
            this.defect_listView.Size = new System.Drawing.Size(121, 97);
            this.defect_listView.TabIndex = 12;
            this.defect_listView.UseCompatibleStateImageBehavior = false;
            this.defect_listView.Visible = false;
            // 
            // LendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.queue_list_groupBox);
            this.Controls.Add(this.item_list_groupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "LendReport";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LendReport";
            this.Load += new System.EventHandler(this.LendReport_Load);
            this.panel1.ResumeLayout(false);
            this.item_list_groupBox.ResumeLayout(false);
            this.item_list_groupBox.PerformLayout();
            this.queue_list_groupBox.ResumeLayout(false);
            this.queue_list_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox item_list_groupBox;
        private System.Windows.Forms.GroupBox queue_list_groupBox;
        private System.Windows.Forms.RadioButton queue_not_returned;
        private System.Windows.Forms.RadioButton queue_returned;
        private System.Windows.Forms.RadioButton item_all_defects;
        private System.Windows.Forms.RadioButton item_all_items;
        private System.Windows.Forms.ListView queue_listView;
        private System.Windows.Forms.ColumnHeader queue_queue;
        private System.Windows.Forms.ColumnHeader queue_name;
        private System.Windows.Forms.ColumnHeader queue_faculty;
        private System.Windows.Forms.ListView item_listView;
        private System.Windows.Forms.ListView defect_listView;
        private System.Windows.Forms.ColumnHeader defect_item_no;
        private System.Windows.Forms.ColumnHeader defect_item_name;
        private System.Windows.Forms.ColumnHeader defect_quantity;
        private System.Windows.Forms.ColumnHeader itemno;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader queue_room;
        private System.Windows.Forms.ColumnHeader queue_time;
    }
}