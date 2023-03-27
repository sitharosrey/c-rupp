namespace Note_Version_2
{
    partial class InsertForm
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
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_new_note = new Guna.UI2.WinForms.Guna2Button();
            this.txt_desc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_title = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BorderRadius = 10;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(12)))));
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(64, 400);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(142, 45);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // btn_new_note
            // 
            this.btn_new_note.BorderRadius = 10;
            this.btn_new_note.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_new_note.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_new_note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_new_note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_new_note.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(207)))), ((int)(((byte)(78)))));
            this.btn_new_note.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_note.ForeColor = System.Drawing.Color.White;
            this.btn_new_note.Location = new System.Drawing.Point(561, 400);
            this.btn_new_note.Name = "btn_new_note";
            this.btn_new_note.Size = new System.Drawing.Size(142, 45);
            this.btn_new_note.TabIndex = 9;
            this.btn_new_note.Text = "New NOTE";
            this.btn_new_note.Click += new System.EventHandler(this.btn_new_note_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.BorderRadius = 10;
            this.txt_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_desc.DefaultText = "";
            this.txt_desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_desc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_desc.Location = new System.Drawing.Point(64, 166);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.PasswordChar = '\0';
            this.txt_desc.PlaceholderText = "";
            this.txt_desc.SelectedText = "";
            this.txt_desc.Size = new System.Drawing.Size(639, 213);
            this.txt_desc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Title";
            // 
            // txt_title
            // 
            this.txt_title.BorderRadius = 10;
            this.txt_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_title.DefaultText = "";
            this.txt_title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_title.Location = new System.Drawing.Point(64, 57);
            this.txt_title.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_title.Name = "txt_title";
            this.txt_title.PasswordChar = '\0';
            this.txt_title.PlaceholderText = "";
            this.txt_title.SelectedText = "";
            this.txt_title.Size = new System.Drawing.Size(639, 56);
            this.txt_title.TabIndex = 16;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(246)))), ((int)(((byte)(204)))));
            this.guna2Panel1.BorderRadius = 237;
            this.guna2Panel1.Controls.Add(this.txt_title);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txt_desc);
            this.guna2Panel1.Controls.Add(this.btn_new_note);
            this.guna2Panel1.Controls.Add(this.btn_back);
            this.guna2Panel1.Location = new System.Drawing.Point(85, 35);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(767, 477);
            this.guna2Panel1.TabIndex = 12;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 545);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "InsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2Button btn_new_note;
        private Guna.UI2.WinForms.Guna2TextBox txt_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_title;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}