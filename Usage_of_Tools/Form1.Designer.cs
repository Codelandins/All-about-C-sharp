namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.MaskedTextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add to The List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(188, 34);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(231, 20);
            this.txtfname.TabIndex = 2;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(188, 70);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(231, 20);
            this.txtlname.TabIndex = 3;
            // 
            // txtjob
            // 
            this.txtjob.Location = new System.Drawing.Point(188, 195);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(231, 20);
            this.txtjob.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Job";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Firstname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lastname";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Age";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gender";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(188, 109);
            this.txtage.Mask = "00";
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(49, 20);
            this.txtage.TabIndex = 16;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(188, 149);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(57, 21);
            this.cmbgender.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 252);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(772, 186);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtage;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.ListBox listBox1;
    }
}

