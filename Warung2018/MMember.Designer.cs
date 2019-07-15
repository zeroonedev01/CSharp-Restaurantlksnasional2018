namespace Warung2018
{
    partial class MMember
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_cari = new System.Windows.Forms.Button();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t_hp = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Form Manage Member";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(774, 199);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // b_cari
            // 
            this.b_cari.Location = new System.Drawing.Point(230, 303);
            this.b_cari.Name = "b_cari";
            this.b_cari.Size = new System.Drawing.Size(75, 23);
            this.b_cari.TabIndex = 41;
            this.b_cari.Text = "Search";
            this.b_cari.UseVisualStyleBackColor = true;
            this.b_cari.Click += new System.EventHandler(this.b_cari_Click);
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(25, 306);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(199, 20);
            this.t_cari.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 71);
            this.panel1.TabIndex = 39;
            // 
            // t_hp
            // 
            this.t_hp.Location = new System.Drawing.Point(526, 391);
            this.t_hp.Name = "t_hp";
            this.t_hp.Size = new System.Drawing.Size(212, 20);
            this.t_hp.TabIndex = 51;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(526, 363);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(212, 20);
            this.t_email.TabIndex = 50;
            // 
            // t_nama
            // 
            this.t_nama.Location = new System.Drawing.Point(526, 337);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(212, 20);
            this.t_nama.TabIndex = 49;
            // 
            // t_id
            // 
            this.t_id.Enabled = false;
            this.t_id.Location = new System.Drawing.Point(526, 306);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(212, 20);
            this.t_id.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Handphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Employee Id";
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(202, 395);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(105, 37);
            this.b_cancel.TabIndex = 56;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click_1);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(91, 395);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(105, 37);
            this.b_save.TabIndex = 55;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(262, 344);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(105, 37);
            this.b_delete.TabIndex = 54;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click_1);
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(151, 344);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(105, 37);
            this.b_edit.TabIndex = 53;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click_1);
            // 
            // b_insert
            // 
            this.b_insert.Location = new System.Drawing.Point(40, 344);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(105, 37);
            this.b_insert.TabIndex = 52;
            this.b_insert.Text = "Insert";
            this.b_insert.UseVisualStyleBackColor = true;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click_1);
            // 
            // MMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.t_hp);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_nama);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_cari);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.panel1);
            this.Name = "MMember";
            this.Text = "MMember";
            this.Load += new System.EventHandler(this.MMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_cari;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox t_hp;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_insert;
    }
}