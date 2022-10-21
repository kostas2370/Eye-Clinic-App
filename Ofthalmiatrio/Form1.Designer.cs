namespace Ofthalmiatrio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(194, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(194, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(379, 79);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(213, 39);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(379, 171);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(213, 39);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // login_butt
            // 
            this.login_butt.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_butt.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_butt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_butt.Location = new System.Drawing.Point(263, 292);
            this.login_butt.Name = "login_butt";
            this.login_butt.Size = new System.Drawing.Size(250, 74);
            this.login_butt.TabIndex = 4;
            this.login_butt.Text = "Login";
            this.login_butt.UseVisualStyleBackColor = false;
            this.login_butt.Click += new System.EventHandler(this.login_butt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_butt);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Button login_butt;
    }
}