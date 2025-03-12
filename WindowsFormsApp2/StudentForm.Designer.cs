namespace WindowsFormsApp2
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.studentpic = new System.Windows.Forms.PictureBox();
            this.age = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.cnumber = new System.Windows.Forms.TextBox();
            this.pgnames = new System.Windows.Forms.TextBox();
            this.pgcnumber = new System.Windows.Forms.TextBox();
            this.hobbies = new System.Windows.Forms.TextBox();
            this.eaddress = new System.Windows.Forms.TextBox();
            this.courseY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(206, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Lawrence L. Sanchez";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name of Parents/Guardian:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Course and Year:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email Address:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact Number:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hobbies:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(265, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Parents/Guardian Contact Number:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // studentpic
            // 
            this.studentpic.Image = ((System.Drawing.Image)(resources.GetObject("studentpic.Image")));
            this.studentpic.Location = new System.Drawing.Point(12, 12);
            this.studentpic.Name = "studentpic";
            this.studentpic.Size = new System.Drawing.Size(118, 112);
            this.studentpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentpic.TabIndex = 0;
            this.studentpic.TabStop = false;
            // 
            // age
            // 
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age.Location = new System.Drawing.Point(350, 147);
            this.age.Multiline = true;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(237, 27);
            this.age.TabIndex = 12;
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Location = new System.Drawing.Point(350, 191);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(237, 27);
            this.address.TabIndex = 13;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cnumber
            // 
            this.cnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnumber.Location = new System.Drawing.Point(350, 238);
            this.cnumber.Multiline = true;
            this.cnumber.Name = "cnumber";
            this.cnumber.Size = new System.Drawing.Size(237, 27);
            this.cnumber.TabIndex = 14;
            this.cnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pgnames
            // 
            this.pgnames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgnames.Location = new System.Drawing.Point(350, 378);
            this.pgnames.Multiline = true;
            this.pgnames.Name = "pgnames";
            this.pgnames.Size = new System.Drawing.Size(237, 27);
            this.pgnames.TabIndex = 15;
            this.pgnames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pgnames.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // pgcnumber
            // 
            this.pgcnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgcnumber.Location = new System.Drawing.Point(350, 425);
            this.pgcnumber.Multiline = true;
            this.pgcnumber.Name = "pgcnumber";
            this.pgcnumber.Size = new System.Drawing.Size(237, 27);
            this.pgcnumber.TabIndex = 16;
            this.pgcnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pgcnumber.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // hobbies
            // 
            this.hobbies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hobbies.Location = new System.Drawing.Point(350, 471);
            this.hobbies.Multiline = true;
            this.hobbies.Name = "hobbies";
            this.hobbies.Size = new System.Drawing.Size(237, 27);
            this.hobbies.TabIndex = 17;
            this.hobbies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hobbies.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // eaddress
            // 
            this.eaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eaddress.Location = new System.Drawing.Point(350, 284);
            this.eaddress.Multiline = true;
            this.eaddress.Name = "eaddress";
            this.eaddress.Size = new System.Drawing.Size(237, 27);
            this.eaddress.TabIndex = 18;
            this.eaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eaddress.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // courseY
            // 
            this.courseY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseY.Location = new System.Drawing.Point(350, 331);
            this.courseY.Multiline = true;
            this.courseY.Name = "courseY";
            this.courseY.Size = new System.Drawing.Size(237, 27);
            this.courseY.TabIndex = 19;
            this.courseY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 556);
            this.Controls.Add(this.courseY);
            this.Controls.Add(this.eaddress);
            this.Controls.Add(this.hobbies);
            this.Controls.Add(this.pgcnumber);
            this.Controls.Add(this.pgnames);
            this.Controls.Add(this.cnumber);
            this.Controls.Add(this.address);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentpic);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox studentpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox cnumber;
        private System.Windows.Forms.TextBox pgnames;
        private System.Windows.Forms.TextBox pgcnumber;
        private System.Windows.Forms.TextBox hobbies;
        private System.Windows.Forms.TextBox eaddress;
        private System.Windows.Forms.TextBox courseY;
    }
}