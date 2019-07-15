namespace Warung2018
{
    partial class FPass
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
            this.b_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpbaru = new System.Windows.Forms.TextBox();
            this.tplama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tcpass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 71);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Form Change Password";
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(189, 188);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(111, 39);
            this.b_save.TabIndex = 45;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Old Password";
            // 
            // tpbaru
            // 
            this.tpbaru.Location = new System.Drawing.Point(189, 119);
            this.tpbaru.Name = "tpbaru";
            this.tpbaru.Size = new System.Drawing.Size(185, 20);
            this.tpbaru.TabIndex = 42;
            // 
            // tplama
            // 
            this.tplama.Location = new System.Drawing.Point(189, 87);
            this.tplama.Name = "tplama";
            this.tplama.Size = new System.Drawing.Size(185, 20);
            this.tplama.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Confirm Password";
            // 
            // tcpass
            // 
            this.tcpass.Location = new System.Drawing.Point(189, 149);
            this.tcpass.Name = "tcpass";
            this.tcpass.Size = new System.Drawing.Size(185, 20);
            this.tcpass.TabIndex = 46;
            // 
            // FPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 239);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcpass);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tpbaru);
            this.Controls.Add(this.tplama);
            this.Controls.Add(this.panel1);
            this.Name = "FPass";
            this.Text = "FPass";
            this.Load += new System.EventHandler(this.FPass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tpbaru;
        private System.Windows.Forms.TextBox tplama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tcpass;
    }
}