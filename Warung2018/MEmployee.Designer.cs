namespace Warung2018
{
    partial class MEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.b_cari = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_hp = new System.Windows.Forms.TextBox();
            this.t_pos = new System.Windows.Forms.ComboBox();
            this.b_insert = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Form Manage Employee";
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(601, 98);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(199, 20);
            this.t_cari.TabIndex = 1;
            this.t_cari.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_cari
            // 
            this.b_cari.Location = new System.Drawing.Point(806, 95);
            this.b_cari.Name = "b_cari";
            this.b_cari.Size = new System.Drawing.Size(75, 23);
            this.b_cari.TabIndex = 2;
            this.b_cari.Text = "Search";
            this.b_cari.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(869, 199);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EmployeeId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Handphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Position";
            // 
            // t_id
            // 
            this.t_id.Enabled = false;
            this.t_id.Location = new System.Drawing.Point(601, 340);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(212, 20);
            this.t_id.TabIndex = 9;
            // 
            // t_nama
            // 
            this.t_nama.Location = new System.Drawing.Point(601, 371);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(212, 20);
            this.t_nama.TabIndex = 10;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(601, 397);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(212, 20);
            this.t_email.TabIndex = 11;
            // 
            // t_hp
            // 
            this.t_hp.Location = new System.Drawing.Point(601, 425);
            this.t_hp.Name = "t_hp";
            this.t_hp.Size = new System.Drawing.Size(212, 20);
            this.t_hp.TabIndex = 12;
            // 
            // t_pos
            // 
            this.t_pos.FormattingEnabled = true;
            this.t_pos.Items.AddRange(new object[] {
            "cashier",
            "admin",
            "chef"});
            this.t_pos.Location = new System.Drawing.Point(601, 454);
            this.t_pos.Name = "t_pos";
            this.t_pos.Size = new System.Drawing.Size(212, 21);
            this.t_pos.TabIndex = 13;
            // 
            // b_insert
            // 
            this.b_insert.Location = new System.Drawing.Point(64, 354);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(105, 37);
            this.b_insert.TabIndex = 14;
            this.b_insert.Text = "Insert";
            this.b_insert.UseVisualStyleBackColor = true;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(196, 350);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(105, 37);
            this.b_edit.TabIndex = 15;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(321, 350);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(105, 37);
            this.b_delete.TabIndex = 16;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(268, 418);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(105, 37);
            this.b_cancel.TabIndex = 18;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(133, 418);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(105, 37);
            this.b_save.TabIndex = 17;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_update_Click);
            // 
            // MEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 492);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.t_pos);
            this.Controls.Add(this.t_hp);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_nama);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_cari);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.panel1);
            this.Name = "MEmployee";
            this.Text = "MEmployee";
            this.Load += new System.EventHandler(this.MEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.Button b_cari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_hp;
        private System.Windows.Forms.ComboBox t_pos;
        private System.Windows.Forms.Button b_insert;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_save;
    }
}