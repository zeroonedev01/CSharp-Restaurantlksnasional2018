namespace Warung2018
{
    partial class Login
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
            this.b_enc = new System.Windows.Forms.Button();
            this.b_decript = new System.Windows.Forms.Button();
            this.t_awal = new System.Windows.Forms.TextBox();
            this.t_encrip = new System.Windows.Forms.TextBox();
            this.t_decrip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SMK Restaurant";
            // 
            // b_enc
            // 
            this.b_enc.Location = new System.Drawing.Point(125, 140);
            this.b_enc.Name = "b_enc";
            this.b_enc.Size = new System.Drawing.Size(75, 23);
            this.b_enc.TabIndex = 5;
            this.b_enc.Text = "Login";
            this.b_enc.UseVisualStyleBackColor = true;
            this.b_enc.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_decript
            // 
            this.b_decript.Location = new System.Drawing.Point(235, 140);
            this.b_decript.Name = "b_decript";
            this.b_decript.Size = new System.Drawing.Size(75, 23);
            this.b_decript.TabIndex = 7;
            this.b_decript.Text = "Login";
            this.b_decript.UseVisualStyleBackColor = true;
            this.b_decript.Click += new System.EventHandler(this.b_decript_Click);
            // 
            // t_awal
            // 
            this.t_awal.Location = new System.Drawing.Point(29, 41);
            this.t_awal.Name = "t_awal";
            this.t_awal.Size = new System.Drawing.Size(353, 20);
            this.t_awal.TabIndex = 8;
            // 
            // t_encrip
            // 
            this.t_encrip.Location = new System.Drawing.Point(29, 85);
            this.t_encrip.Name = "t_encrip";
            this.t_encrip.Size = new System.Drawing.Size(353, 20);
            this.t_encrip.TabIndex = 9;
            // 
            // t_decrip
            // 
            this.t_decrip.Location = new System.Drawing.Point(29, 114);
            this.t_decrip.Name = "t_decrip";
            this.t_decrip.Size = new System.Drawing.Size(353, 20);
            this.t_decrip.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 209);
            this.Controls.Add(this.t_decrip);
            this.Controls.Add(this.t_encrip);
            this.Controls.Add(this.t_awal);
            this.Controls.Add(this.b_decript);
            this.Controls.Add(this.b_enc);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_enc;
        private System.Windows.Forms.Button b_decript;
        private System.Windows.Forms.TextBox t_awal;
        private System.Windows.Forms.TextBox t_encrip;
        private System.Windows.Forms.TextBox t_decrip;
    }
}