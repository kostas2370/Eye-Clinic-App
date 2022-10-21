namespace Ofthalmiatrio
{
    partial class editpatient
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
            this.asfaleia = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.asfaleia);
            this.panel1.Controls.Add(this.fullname);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 364);
            this.panel1.TabIndex = 0;
            // 
            // asfaleia
            // 
            this.asfaleia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asfaleia.Location = new System.Drawing.Point(159, 153);
            this.asfaleia.Name = "asfaleia";
            this.asfaleia.Size = new System.Drawing.Size(208, 36);
            this.asfaleia.TabIndex = 7;
            // 
            // fullname
            // 
            this.fullname.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullname.Location = new System.Drawing.Point(159, 98);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(208, 36);
            this.fullname.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(146, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asfaleia :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fullname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(171, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit :";
            // 
            // editpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 358);
            this.Controls.Add(this.panel1);
            this.Name = "editpatient";
            this.Text = "editpatient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox asfaleia;
        private TextBox fullname;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}