namespace Ofthalmiatrio
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.movetomedicine = new System.Windows.Forms.Button();
            this.patientbut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.userdatagrid = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editbut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletebut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.show_all_butt = new System.Windows.Forms.Button();
            this.searchbutt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.usersearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.movetomedicine);
            this.panel1.Controls.Add(this.patientbut);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 61);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(690, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 58);
            this.button4.TabIndex = 5;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(558, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 61);
            this.button3.TabIndex = 4;
            this.button3.Text = "Users";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // movetomedicine
            // 
            this.movetomedicine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.movetomedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.movetomedicine.FlatAppearance.BorderSize = 0;
            this.movetomedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movetomedicine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movetomedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.movetomedicine.Location = new System.Drawing.Point(448, -1);
            this.movetomedicine.Name = "movetomedicine";
            this.movetomedicine.Size = new System.Drawing.Size(114, 63);
            this.movetomedicine.TabIndex = 4;
            this.movetomedicine.Text = "Medicines";
            this.movetomedicine.UseVisualStyleBackColor = false;
            this.movetomedicine.Click += new System.EventHandler(this.movetomedicine_Click);
            // 
            // patientbut
            // 
            this.patientbut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.patientbut.FlatAppearance.BorderSize = 0;
            this.patientbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientbut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientbut.Location = new System.Drawing.Point(328, -2);
            this.patientbut.Name = "patientbut";
            this.patientbut.Size = new System.Drawing.Size(114, 61);
            this.patientbut.TabIndex = 3;
            this.patientbut.Text = "Patients";
            this.patientbut.UseVisualStyleBackColor = false;
            this.patientbut.Click += new System.EventHandler(this.patientbut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(66, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eye Clinic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 65);
            this.label1.TabIndex = 0;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
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
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 441);
            this.panel2.TabIndex = 5;
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
            this.button1.Text = "Add User";
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
            this.label3.Size = new System.Drawing.Size(124, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add user:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.userdatagrid);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.show_all_butt);
            this.panel3.Controls.Add(this.searchbutt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.usersearch);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(369, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 441);
            this.panel3.TabIndex = 6;
            // 
            // userdatagrid
            // 
            this.userdatagrid.AllowUserToAddRows = false;
            this.userdatagrid.AllowUserToDeleteRows = false;
            this.userdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.username,
            this.password,
            this.role,
            this.editbut,
            this.deletebut});
            this.userdatagrid.Location = new System.Drawing.Point(36, 214);
            this.userdatagrid.Name = "userdatagrid";
            this.userdatagrid.ReadOnly = true;
            this.userdatagrid.RowTemplate.Height = 25;
            this.userdatagrid.Size = new System.Drawing.Size(413, 201);
            this.userdatagrid.TabIndex = 12;
            this.userdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userdatagrid_CellContentClick);
            this.userdatagrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.userdatagrid_CellFormatting);
            // 
            // userid
            // 
            this.userid.HeaderText = "ID";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Width = 40;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 80;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 80;
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Width = 70;
            // 
            // editbut
            // 
            this.editbut.HeaderText = "Edit";
            this.editbut.Name = "editbut";
            this.editbut.ReadOnly = true;
            this.editbut.Text = "edit";
            this.editbut.UseColumnTextForButtonValue = true;
            this.editbut.Width = 70;
            // 
            // deletebut
            // 
            this.deletebut.HeaderText = "Delete";
            this.deletebut.Name = "deletebut";
            this.deletebut.ReadOnly = true;
            this.deletebut.Text = "Delete";
            this.deletebut.UseColumnTextForButtonValue = true;
            this.deletebut.Width = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(203, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 36);
            this.label10.TabIndex = 11;
            this.label10.Text = "Users :";
            // 
            // show_all_butt
            // 
            this.show_all_butt.BackColor = System.Drawing.SystemColors.Highlight;
            this.show_all_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.show_all_butt.FlatAppearance.BorderSize = 0;
            this.show_all_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_all_butt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.show_all_butt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_all_butt.Location = new System.Drawing.Point(335, 127);
            this.show_all_butt.Name = "show_all_butt";
            this.show_all_butt.Size = new System.Drawing.Size(114, 40);
            this.show_all_butt.TabIndex = 10;
            this.show_all_butt.Text = "Show all";
            this.show_all_butt.UseVisualStyleBackColor = false;
            this.show_all_butt.Click += new System.EventHandler(this.show_all_butt_Click);
            // 
            // searchbutt
            // 
            this.searchbutt.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchbutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchbutt.FlatAppearance.BorderSize = 0;
            this.searchbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchbutt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbutt.Location = new System.Drawing.Point(335, 81);
            this.searchbutt.Name = "searchbutt";
            this.searchbutt.Size = new System.Drawing.Size(114, 40);
            this.searchbutt.TabIndex = 9;
            this.searchbutt.Text = "Search";
            this.searchbutt.UseVisualStyleBackColor = false;
            this.searchbutt.Click += new System.EventHandler(this.searchbutt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(45, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Username :";
            // 
            // usersearch
            // 
            this.usersearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersearch.Location = new System.Drawing.Point(157, 99);
            this.usersearch.Name = "usersearch";
            this.usersearch.Size = new System.Drawing.Size(172, 32);
            this.usersearch.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(189, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 36);
            this.label8.TabIndex = 1;
            this.label8.Text = "Search user:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 505);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userdatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button movetomedicine;
        private Button patientbut;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
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
        private Panel panel3;
        private DataGridView userdatagrid;
        private Label label10;
        private Button show_all_butt;
        private Button searchbutt;
        private Label label9;
        private TextBox usersearch;
        private Label label8;
        private DataGridViewTextBoxColumn userid;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn role;
        private DataGridViewButtonColumn editbut;
        private DataGridViewButtonColumn deletebut;
    }
}