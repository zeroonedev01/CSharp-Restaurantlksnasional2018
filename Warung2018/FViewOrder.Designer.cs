namespace Warung2018
{
    partial class FViewOrder
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.t_id2 = new System.Windows.Forms.Label();
            this.t_id1 = new System.Windows.Forms.Label();
            this.t_status2 = new System.Windows.Forms.ComboBox();
            this.t_2 = new System.Windows.Forms.Label();
            this.t_status1 = new System.Windows.Forms.ComboBox();
            this.t_1 = new System.Windows.Forms.Label();
            this.b_cari = new System.Windows.Forms.Button();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmb_short = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 445);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.cmb_id);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 324);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // cmb_id
            // 
            this.cmb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(302, 14);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(164, 21);
            this.cmb_id.TabIndex = 2;
            this.cmb_id.SelectedIndexChanged += new System.EventHandler(this.cmb_id_SelectedIndexChanged);
            this.cmb_id.TextChanged += new System.EventHandler(this.cmb_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Id";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.t_id2);
            this.tabPage2.Controls.Add(this.t_id1);
            this.tabPage2.Controls.Add(this.t_status2);
            this.tabPage2.Controls.Add(this.t_2);
            this.tabPage2.Controls.Add(this.t_status1);
            this.tabPage2.Controls.Add(this.t_1);
            this.tabPage2.Controls.Add(this.b_cari);
            this.tabPage2.Controls.Add(this.t_cari);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.cmb_short);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Overview";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 336);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(617, 64);
            this.flowLayoutPanel1.TabIndex = 50;
            // 
            // t_id2
            // 
            this.t_id2.AutoSize = true;
            this.t_id2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_id2.Location = new System.Drawing.Point(466, 274);
            this.t_id2.Name = "t_id2";
            this.t_id2.Size = new System.Drawing.Size(40, 16);
            this.t_id2.TabIndex = 49;
            this.t_id2.Text = "2001";
            // 
            // t_id1
            // 
            this.t_id1.AutoSize = true;
            this.t_id1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_id1.Location = new System.Drawing.Point(50, 274);
            this.t_id1.Name = "t_id1";
            this.t_id1.Size = new System.Drawing.Size(40, 16);
            this.t_id1.TabIndex = 48;
            this.t_id1.Text = "1999";
            // 
            // t_status2
            // 
            this.t_status2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_status2.FormattingEnabled = true;
            this.t_status2.Items.AddRange(new object[] {
            "Preparation",
            "Cooking",
            "Delivered"});
            this.t_status2.Location = new System.Drawing.Point(483, 296);
            this.t_status2.Name = "t_status2";
            this.t_status2.Size = new System.Drawing.Size(175, 21);
            this.t_status2.TabIndex = 47;
            this.t_status2.SelectedIndexChanged += new System.EventHandler(this.t_status2_SelectedIndexChanged);
            this.t_status2.Click += new System.EventHandler(this.t_status2_Click);
            // 
            // t_2
            // 
            this.t_2.AutoSize = true;
            this.t_2.Location = new System.Drawing.Point(446, 302);
            this.t_2.Name = "t_2";
            this.t_2.Size = new System.Drawing.Size(13, 13);
            this.t_2.TabIndex = 46;
            this.t_2.Text = "2";
            // 
            // t_status1
            // 
            this.t_status1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_status1.FormattingEnabled = true;
            this.t_status1.Items.AddRange(new object[] {
            "Preparation",
            "Cooking",
            "Delivered"});
            this.t_status1.Location = new System.Drawing.Point(80, 299);
            this.t_status1.Name = "t_status1";
            this.t_status1.Size = new System.Drawing.Size(175, 21);
            this.t_status1.TabIndex = 45;
            this.t_status1.SelectedIndexChanged += new System.EventHandler(this.t_status1_SelectedIndexChanged);
            this.t_status1.Click += new System.EventHandler(this.t_status1_Click);
            // 
            // t_1
            // 
            this.t_1.AutoSize = true;
            this.t_1.Location = new System.Drawing.Point(50, 299);
            this.t_1.Name = "t_1";
            this.t_1.Size = new System.Drawing.Size(13, 13);
            this.t_1.TabIndex = 44;
            this.t_1.Text = "1";
            // 
            // b_cari
            // 
            this.b_cari.Location = new System.Drawing.Point(622, 13);
            this.b_cari.Name = "b_cari";
            this.b_cari.Size = new System.Drawing.Size(75, 23);
            this.b_cari.TabIndex = 43;
            this.b_cari.Text = "Search";
            this.b_cari.UseVisualStyleBackColor = true;
            this.b_cari.Click += new System.EventHandler(this.b_cari_Click);
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(408, 13);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(199, 20);
            this.t_cari.TabIndex = 42;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(691, 199);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // cmb_short
            // 
            this.cmb_short.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_short.FormattingEnabled = true;
            this.cmb_short.Items.AddRange(new object[] {
            "Name",
            "Qty"});
            this.cmb_short.Location = new System.Drawing.Point(66, 10);
            this.cmb_short.Name = "cmb_short";
            this.cmb_short.Size = new System.Drawing.Size(164, 21);
            this.cmb_short.TabIndex = 5;
            this.cmb_short.SelectedIndexChanged += new System.EventHandler(this.cmb_short_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sort by:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 54);
            this.panel1.TabIndex = 57;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(300, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "From View Order";
            // 
            // FViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FViewOrder";
            this.Text = "FViewOrder";
            this.Load += new System.EventHandler(this.FViewOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmb_short;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_cari;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.ComboBox t_status1;
        private System.Windows.Forms.Label t_1;
        private System.Windows.Forms.ComboBox t_status2;
        private System.Windows.Forms.Label t_2;
        private System.Windows.Forms.Label t_id2;
        private System.Windows.Forms.Label t_id1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}