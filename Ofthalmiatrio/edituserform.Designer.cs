namespace Ofthalmiatrio
{
    partial class edituserform
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.roles = new System.Windows.Forms.ComboBox();
            this.password_ver_text = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.roles);
            this.panel2.Controls.Add(this.password_ver_text);
            this.panel2.Controls.Add(this.passwordtext);
            this.panel2.Controls.Add(this.usernametext);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 441);
            this.panel2.TabIndex = 6;
            // 
            // roles
            // 
            this.roles.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roles.FormattingEnabled = true;
            this.roles.Items.AddRange(new object[] {
            "no role",
            "admin",
            "doctor",
            "secretary",
            "drug specialist"});
            this.roles.Location = new System.Drawing.Point(172, 258);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(172, 33);
            this.roles.TabIndex = 9;
            // 
            // password_ver_text
            // 
            this.password_ver_text.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_ver_text.Location = new System.Drawing.Point(172, 202);
            this.password_ver_text.Name = "password_ver_text";
            this.password_ver_text.Size = new System.Drawing.Size(172, 32);
            this.password_ver_text.TabIndex = 8;
            this.password_ver_text.UseSystemPasswordChar = true;
            // 
            // passwordtext
            // 
            this.passwordtext.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordtext.Location = new System.Drawing.Point(172, 149);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(172, 32);
            this.passwordtext.TabIndex = 7;
            this.passwordtext.UseSystemPasswordChar = true;
            // 
            // usernametext
            // 
            this.usernametext.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernametext.Location = new System.Drawing.Point(172, 93);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(172, 32);
            this.usernametext.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(125, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Role :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "re-Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(115, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update User:";
            // 
            // edituserform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 436);
            this.Controls.Add(this.panel2);
            this.Name = "edituserform";
            this.Text = "edituserform";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private ComboBox roles;
        private TextBox password_ver_text;
        private TextBox passwordtext;
        private TextBox usernametext;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}