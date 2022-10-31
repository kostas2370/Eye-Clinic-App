namespace Ofthalmiatrio
{
    partial class MedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.userbutt = new System.Windows.Forms.Button();
            this.movetomedicine = new System.Windows.Forms.Button();
            this.patientbut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add_med_butt = new System.Windows.Forms.Button();
            this.promitheftes = new System.Windows.Forms.RichTextBox();
            this.symptomata = new System.Windows.Forms.RichTextBox();
            this.fas = new System.Windows.Forms.RadioButton();
            this.auth = new System.Windows.Forms.RadioButton();
            this.onoma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showall = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.medicingridview = new System.Windows.Forms.DataGridView();
            this.ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.types = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicingridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.userbutt);
            this.panel1.Controls.Add(this.movetomedicine);
            this.panel1.Controls.Add(this.patientbut);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 61);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(755, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 58);
            this.button4.TabIndex = 5;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.logout_Click);
            // 
            // userbutt
            // 
            this.userbutt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userbutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userbutt.FlatAppearance.BorderSize = 0;
            this.userbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userbutt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userbutt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userbutt.Location = new System.Drawing.Point(607, 0);
            this.userbutt.Name = "userbutt";
            this.userbutt.Size = new System.Drawing.Size(126, 61);
            this.userbutt.TabIndex = 4;
            this.userbutt.Text = "Users";
            this.userbutt.UseVisualStyleBackColor = false;
            this.userbutt.Click += new System.EventHandler(this.settings_Click);
            // 
            // movetomedicine
            // 
            this.movetomedicine.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.movetomedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.movetomedicine.FlatAppearance.BorderSize = 0;
            this.movetomedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movetomedicine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movetomedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.movetomedicine.Location = new System.Drawing.Point(487, -2);
            this.movetomedicine.Name = "movetomedicine";
            this.movetomedicine.Size = new System.Drawing.Size(114, 63);
            this.movetomedicine.TabIndex = 4;
            this.movetomedicine.Text = "Medicines";
            this.movetomedicine.UseVisualStyleBackColor = false;
            // 
            // patientbut
            // 
            this.patientbut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.patientbut.FlatAppearance.BorderSize = 0;
            this.patientbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientbut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientbut.Location = new System.Drawing.Point(364, -2);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.add_med_butt);
            this.panel2.Controls.Add(this.promitheftes);
            this.panel2.Controls.Add(this.symptomata);
            this.panel2.Controls.Add(this.fas);
            this.panel2.Controls.Add(this.auth);
            this.panel2.Controls.Add(this.onoma);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 618);
            this.panel2.TabIndex = 4;
            // 
            // add_med_butt
            // 
            this.add_med_butt.BackColor = System.Drawing.SystemColors.Highlight;
            this.add_med_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_med_butt.FlatAppearance.BorderSize = 0;
            this.add_med_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_med_butt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_med_butt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_med_butt.Location = new System.Drawing.Point(133, 531);
            this.add_med_butt.Name = "add_med_butt";
            this.add_med_butt.Size = new System.Drawing.Size(156, 61);
            this.add_med_butt.TabIndex = 5;
            this.add_med_butt.Text = "Add Medicine";
            this.add_med_butt.UseVisualStyleBackColor = false;
            this.add_med_butt.Click += new System.EventHandler(this.add_med_butt_Click);
            // 
            // promitheftes
            // 
            this.promitheftes.Location = new System.Drawing.Point(12, 421);
            this.promitheftes.Name = "promitheftes";
            this.promitheftes.Size = new System.Drawing.Size(392, 82);
            this.promitheftes.TabIndex = 9;
            this.promitheftes.Text = "";
            // 
            // symptomata
            // 
            this.symptomata.Location = new System.Drawing.Point(12, 237);
            this.symptomata.Name = "symptomata";
            this.symptomata.Size = new System.Drawing.Size(392, 148);
            this.symptomata.TabIndex = 8;
            this.symptomata.Text = "";
            // 
            // fas
            // 
            this.fas.AutoSize = true;
            this.fas.Location = new System.Drawing.Point(337, 157);
            this.fas.Name = "fas";
            this.fas.Size = new System.Drawing.Size(65, 19);
            this.fas.TabIndex = 7;
            this.fas.TabStop = true;
            this.fas.Text = "Φασών";
            this.fas.UseVisualStyleBackColor = true;
            // 
            // auth
            // 
            this.auth.AutoSize = true;
            this.auth.Location = new System.Drawing.Point(224, 157);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(80, 19);
            this.auth.TabIndex = 6;
            this.auth.TabStop = true;
            this.auth.Text = "Aυθεντικό";
            this.auth.UseVisualStyleBackColor = true;
            // 
            // onoma
            // 
            this.onoma.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.onoma.Location = new System.Drawing.Point(224, 98);
            this.onoma.Name = "onoma";
            this.onoma.Size = new System.Drawing.Size(194, 35);
            this.onoma.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "Προμηθευτές:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Συμπτωματολογία :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Αυθεντικότητα :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Όνομα :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add medicine :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.showall);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.medicingridview);
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(424, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 618);
            this.panel3.TabIndex = 5;
            // 
            // showall
            // 
            this.showall.BackColor = System.Drawing.SystemColors.Highlight;
            this.showall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showall.FlatAppearance.BorderSize = 0;
            this.showall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showall.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showall.Location = new System.Drawing.Point(299, 141);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(156, 35);
            this.showall.TabIndex = 11;
            this.showall.Text = "Show all";
            this.showall.UseVisualStyleBackColor = false;
            this.showall.Click += new System.EventHandler(this.showall_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(299, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.search_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(164, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Medicines:";
            // 
            // medicingridview
            // 
            this.medicingridview.AllowUserToAddRows = false;
            this.medicingridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.medicingridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medicingridview.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.medicingridview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicingridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medicingridview.ColumnHeadersHeight = 35;
            this.medicingridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ids,
            this.farmname,
            this.types,
            this.symp,
            this.proms,
            this.delete,
            this.Edit,
            this.Save,
            this.Print});
            this.medicingridview.Location = new System.Drawing.Point(16, 220);
            this.medicingridview.Name = "medicingridview";
            this.medicingridview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicingridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.medicingridview.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.medicingridview.RowTemplate.Height = 25;
            this.medicingridview.Size = new System.Drawing.Size(439, 283);
            this.medicingridview.TabIndex = 7;
            this.medicingridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicingridview_CellContentClick);
            this.medicingridview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicingridview_CellContentDoubleClick);
            // 
            // ids
            // 
            this.ids.Frozen = true;
            this.ids.HeaderText = "ID";
            this.ids.Name = "ids";
            this.ids.ReadOnly = true;
            this.ids.Width = 40;
            // 
            // farmname
            // 
            this.farmname.Frozen = true;
            this.farmname.HeaderText = "Όνομα";
            this.farmname.Name = "farmname";
            this.farmname.ReadOnly = true;
            // 
            // types
            // 
            this.types.HeaderText = "Τύπος";
            this.types.Name = "types";
            this.types.ReadOnly = true;
            this.types.Width = 67;
            // 
            // symp
            // 
            this.symp.HeaderText = "Συμπτωματολογία";
            this.symp.Name = "symp";
            this.symp.ReadOnly = true;
            this.symp.Width = 115;
            // 
            // proms
            // 
            this.proms.HeaderText = "Προμηθευτές";
            this.proms.Name = "proms";
            this.proms.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 70;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Update";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Update";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 70;
            // 
            // Save
            // 
            this.Save.HeaderText = "Save";
            this.Save.Name = "Save";
            this.Save.ReadOnly = true;
            this.Save.Text = "Save";
            this.Save.UseColumnTextForButtonValue = true;
            this.Save.Width = 70;
            // 
            // Print
            // 
            this.Print.HeaderText = "Print";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Text = "Print";
            this.Print.UseColumnTextForButtonValue = true;
            this.Print.Width = 70;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(25, 100);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(233, 35);
            this.search.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(141, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "Search medicine :";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Όνομα";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 680);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MedicineForm";
            this.Text = "MedicineForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicingridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button userbutt;
        private Button movetomedicine;
        private Button patientbut;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Button add_med_butt;
        private RichTextBox promitheftes;
        private RichTextBox symptomata;
        private RadioButton fas;
        private RadioButton auth;
        private TextBox onoma;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel3;
        private Label label8;
        private Button button2;
        private Label label9;
        private DataGridView medicingridview;
        private TextBox search;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button showall;
        private DataGridViewTextBoxColumn ids;
        private DataGridViewTextBoxColumn farmname;
        private DataGridViewTextBoxColumn types;
        private DataGridViewTextBoxColumn symp;
        private DataGridViewTextBoxColumn proms;
        private DataGridViewButtonColumn delete;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Save;
        private DataGridViewButtonColumn Print;
    }
}