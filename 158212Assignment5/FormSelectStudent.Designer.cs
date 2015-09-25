namespace _158212Assignment5
{
    partial class FormSelectStudent
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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(12, 43);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(268, 420);
            this.listBoxStudents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Students";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(28, 527);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 30);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(152, 527);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 30);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "AddStudent Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "The selected Student ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(155, 488);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 20);
            this.textBoxID.TabIndex = 6;
            // 
            // FormSelectStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 569);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStudents);
            this.Name = "FormSelectStudent";
            this.Text = "FormSelectStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
    }
}