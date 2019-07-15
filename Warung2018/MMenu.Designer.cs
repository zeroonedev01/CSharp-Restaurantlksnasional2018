namespace Warung2018
{
    partial class MMenu
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
            this.t_photo = new System.Windows.Forms.TextBox();
            this.t_price = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_cari = new System.Windows.Forms.Button();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.t_carbo = new System.Windows.Forms.TextBox();
            this.t_protein = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_insert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // t_photo
            // 
            this.t_photo.Enabled = false;
            this.t_photo.Location = new System.Drawing.Point(331, 410);
            this.t_photo.Name = "t_photo";
            this.t_photo.Size = new System.Drawing.Size(162, 20);
            this.t_photo.TabIndex = 29;
            // 
            // t_price
            // 
            this.t_price.Location = new System.Drawing.Point(331, 382);
            this.t_price.Name = "t_price";
            this.t_price.Size = new System.Drawing.Size(212, 20);
            this.t_price.TabIndex = 28;
            // 
            // t_nama
            // 
            this.t_nama.Location = new System.Drawing.Point(331, 356);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(212, 20);
            this.t_nama.TabIndex = 27;
            this.t_nama.Leave += new System.EventHandler(this.t_nama_Leave);
            // 
            // t_id
            // 
            this.t_id.Enabled = false;
            this.t_id.Location = new System.Drawing.Point(331, 325);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(212, 20);
            this.t_id.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Carbo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Photo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "MenuId";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(869, 199);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // b_cari
            // 
            this.b_cari.Location = new System.Drawing.Point(809, 76);
            this.b_cari.Name = "b_cari";
            this.b_cari.Size = new System.Drawing.Size(75, 23);
            this.b_cari.TabIndex = 19;
            this.b_cari.Text = "Search";
            this.b_cari.UseVisualStyleBackColor = true;
            this.b_cari.Click += new System.EventHandler(this.b_cari_Click);
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(604, 79);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(199, 20);
            this.t_cari.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Form Manage Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 71);
            this.panel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 22);
            this.button1.TabIndex = 34;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_carbo
            // 
            this.t_carbo.Location = new System.Drawing.Point(331, 440);
            this.t_carbo.Name = "t_carbo";
            this.t_carbo.Size = new System.Drawing.Size(212, 20);
            this.t_carbo.TabIndex = 35;
            // 
            // t_protein
            // 
            this.t_protein.Location = new System.Drawing.Point(331, 466);
            this.t_protein.Name = "t_protein";
            this.t_protein.Size = new System.Drawing.Size(212, 20);
            this.t_protein.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Protein";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(725, 423);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(105, 37);
            this.b_cancel.TabIndex = 61;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(614, 423);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(105, 37);
            this.b_save.TabIndex = 60;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(780, 365);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(105, 37);
            this.b_delete.TabIndex = 59;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(669, 365);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(105, 37);
            this.b_edit.TabIndex = 58;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_insert
            // 
            this.b_insert.Location = new System.Drawing.Point(558, 365);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(105, 37);
            this.b_insert.TabIndex = 57;
            this.b_insert.Text = "Insert";
            this.b_insert.UseVisualStyleBackColor = true;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // MMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 497);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.t_protein);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_carbo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_photo);
            this.Controls.Add(this.t_price);
            this.Controls.Add(this.t_nama);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_cari);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "MMenu";
            this.Text = "MMenu";
            this.Load += new System.EventHandler(this.MMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t_photo;
        private System.Windows.Forms.TextBox t_price;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_cari;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_carbo;
        private System.Windows.Forms.TextBox t_protein;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_insert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}