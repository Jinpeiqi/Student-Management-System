using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _University;
using System.IO;

namespace _158212Assignment5
{
    public partial class MainForm : Form
    {
        Data _data = new Data();
        public MainForm()
        {
            InitializeComponent();

        }

        private int studentIndex = -1;
        public int StudentIndex { get { return studentIndex; } set { studentIndex = value; } }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            studentIndex = -1;
            FormStudent fs = new FormStudent(this);
            fs.ShowDialog();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            StudentIndex = listBoxStudents.SelectedIndex;
            FormStudent fs = new FormStudent(this);
            fs.ShowDialog();
        }

        private int paperIndex = -1;
        public int PaperIndex
        {
            get { return paperIndex; }
            set { paperIndex = value; }
        }

        private void btnAddPaper_Click(object sender, EventArgs e)
        {
            paperIndex = -1;
            FormPaper fp = new FormPaper(this);
            fp.ShowDialog();
        }

        private void btnEditPaper_Click(object sender, EventArgs e)
        {
            PaperIndex = listBoxPapers.SelectedIndex;
            FormPaper fp = new FormPaper(this);
            fp.ShowDialog();
        }

        internal void PopulateStudent()
        {
            listBoxStudents.DataSource = null;
            List<Students> tempList = new List<Students>(_data.GetStudentList());
            listBoxStudents.DataSource = tempList;
        }

        internal void PopulatePaper()
        {
            listBoxPapers.DataSource = null;
            List<Papers> tempList = new List<Papers>(_data.GetPapersList());
            listBoxPapers.DataSource = tempList;
        }

        private void closeCurrentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete all current data?", "Warning!", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                _data.DeleteAllList();
                listBoxPapers.DataSource = null;
                listBoxStudents.DataSource = null;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateStudentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _data.UpdatsStudentsList();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "UniversityDataFile1.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {

                    int totalStudents = _data.CountStudentsList();
                    for (int i = 0; i < totalStudents; i++)
                    {
                        sw.WriteLine(_data.PrintStudent(_data.GetStudentList(), i));
                    }

                    int totalPapers = _data.CountPapersList();
                    for (int j = 0; j < totalPapers; j++)
                    {
                        sw.WriteLine(_data.PrintPaper(_data.GetPapersList(), j));
                    }
                }
            }
        }
    }
}