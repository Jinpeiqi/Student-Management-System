namespace _158212Assignment5
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnEditPaper = new System.Windows.Forms.Button();
            this.btnAddPaper = new System.Windows.Forms.Button();
            this.listBoxPapers = new System.Windows.Forms.ListBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(26, 41);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(237, 381);
            this.listBoxStudents.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.updateStudentsListToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(571, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeCurrentDataToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeCurrentDataToolStripMenuItem
            // 
            this.closeCurrentDataToolStripMenuItem.Name = "closeCurrentDataToolStripMenuItem";
            this.closeCurrentDataToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.closeCurrentDataToolStripMenuItem.Text = "Close Current data";
            this.closeCurrentDataToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // updateStudentsListToolStripMenuItem
            // 
            this.updateStudentsListToolStripMenuItem.Name = "updateStudentsListToolStripMenuItem";
            this.updateStudentsListToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.updateStudentsListToolStripMenuItem.Text = "Update Students";
            this.updateStudentsListToolStripMenuItem.Click += new System.EventHandler(this.updateStudentsListToolStripMenuItem_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(26, 433);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(110, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Add New Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(153, 433);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(110, 23);
            this.btnEditStudent.TabIndex = 5;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnEditPaper
            // 
            this.btnEditPaper.Location = new System.Drawing.Point(426, 433);
            this.btnEditPaper.Name = "btnEditPaper";
            this.btnEditPaper.Size = new System.Drawing.Size(110, 23);
            this.btnEditPaper.TabIndex = 8;
            this.btnEditPaper.Text = "Edit Paper";
            this.btnEditPaper.UseVisualStyleBackColor = true;
            this.btnEditPaper.Click += new System.EventHandler(this.btnEditPaper_Click);
            // 
            // btnAddPaper
            // 
            this.btnAddPaper.Location = new System.Drawing.Point(299, 433);
            this.btnAddPaper.Name = "btnAddPaper";
            this.btnAddPaper.Size = new System.Drawing.Size(110, 23);
            this.btnAddPaper.TabIndex = 7;
            this.btnAddPaper.Text = "Add New Paper";
            this.btnAddPaper.UseVisualStyleBackColor = true;
            this.btnAddPaper.Click += new System.EventHandler(this.btnAddPaper_Click);
            // 
            // listBoxPapers
            // 
            this.listBoxPapers.FormattingEnabled = true;
            this.listBoxPapers.Location = new System.Drawing.Point(299, 41);
            this.listBoxPapers.Name = "listBoxPapers";
            this.listBoxPapers.Size = new System.Drawing.Size(237, 381);
            this.listBoxPapers.TabIndex = 6;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 468);
            this.Controls.Add(this.btnEditPaper);
            this.Controls.Add(this.btnAddPaper);
            this.Controls.Add(this.listBoxPapers);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Student Management System";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnEditPaper;
        private System.Windows.Forms.Button btnAddPaper;
        private System.Windows.Forms.ListBox listBoxPapers;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentsListToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

