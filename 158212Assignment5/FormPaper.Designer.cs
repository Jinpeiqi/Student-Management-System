namespace _158212Assignment5
{
    partial class FormPaper
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxCooridinator = new System.Windows.Forms.TextBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.btnDelStu = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Cooridinator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Students:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(118, 116);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCode.TabIndex = 5;
            // 
            // textBoxCooridinator
            // 
            this.textBoxCooridinator.Location = new System.Drawing.Point(118, 177);
            this.textBoxCooridinator.Name = "textBoxCooridinator";
            this.textBoxCooridinator.Size = new System.Drawing.Size(159, 20);
            this.textBoxCooridinator.TabIndex = 6;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(355, 55);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(285, 433);
            this.listBoxStudents.TabIndex = 7;
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(194, 280);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(144, 23);
            this.btnAddStu.TabIndex = 8;
            this.btnAddStu.Text = "Add new student";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // btnDelStu
            // 
            this.btnDelStu.Location = new System.Drawing.Point(194, 353);
            this.btnDelStu.Name = "btnDelStu";
            this.btnDelStu.Size = new System.Drawing.Size(144, 23);
            this.btnDelStu.TabIndex = 9;
            this.btnDelStu.Text = "Delete selescted student";
            this.btnDelStu.UseVisualStyleBackColor = true;
            this.btnDelStu.Click += new System.EventHandler(this.btnDelStu_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(503, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 406);
            this.label5.MaximumSize = new System.Drawing.Size(200, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Note: the change on student will  activate immediately without click [Save] butto" +
                "n";
            // 
            // FormPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 551);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelStu);
            this.Controls.Add(this.btnAddStu);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.textBoxCooridinator);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPaper";
            this.Text = "FormPaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxCooridinator;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.Button btnDelStu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
    }
}