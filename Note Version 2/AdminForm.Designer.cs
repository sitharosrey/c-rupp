namespace Note_Version_2
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_manage_user = new Guna.UI2.WinForms.Guna2Button();
            this.btn_log_out = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(207)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(455, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcom,";
            // 
            // btn_manage_user
            // 
            this.btn_manage_user.BorderRadius = 10;
            this.btn_manage_user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_manage_user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_manage_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_manage_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_manage_user.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(207)))), ((int)(((byte)(78)))));
            this.btn_manage_user.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_user.ForeColor = System.Drawing.Color.White;
            this.btn_manage_user.Location = new System.Drawing.Point(488, 457);
            this.btn_manage_user.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_manage_user.Name = "btn_manage_user";
            this.btn_manage_user.Size = new System.Drawing.Size(171, 45);
            this.btn_manage_user.TabIndex = 9;
            this.btn_manage_user.Text = "Manage Users";
            this.btn_manage_user.Click += new System.EventHandler(this.btn_manage_user_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.BorderRadius = 10;
            this.btn_log_out.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_log_out.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_log_out.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_log_out.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_log_out.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(12)))));
            this.btn_log_out.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.Color.White;
            this.btn_log_out.Location = new System.Drawing.Point(204, 457);
            this.btn_log_out.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(171, 45);
            this.btn_log_out.TabIndex = 10;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 545);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_manage_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_manage_user;
        private Guna.UI2.WinForms.Guna2Button btn_log_out;
    }
}