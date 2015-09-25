using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _University;

namespace _158212Assignment5
{
    public partial class FormPaper : Form
    {
        MainForm form1;
        public FormPaper(MainForm incomingForm)
        {
            form1 = incomingForm;
            InitializeComponent();
            LoadPaper();
            
        }

        Data _data = new Data();
        Papers aPaper = new Papers();
        public void LoadPaper()
        {
            if (form1.PaperIndex != -1)
            {
                List<Papers> _paperList = _data.GetPapersList();
                aPaper = _paperList[form1.PaperIndex];
                textBoxName.Text = aPaper.Name;
                textBoxCode.Text = Convert.ToString(aPaper.PaperCode);
                textBoxCooridinator.Text = aPaper.Cooridinator;
                listBoxStudents.DataSource = aPaper.StudentsID;
            }
            else
            {
                textBoxName.Clear();
                textBoxCode.Clear();
                textBoxCooridinator.Clear();
                listBoxStudents.DataSource = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double paperCode = 0;
            try
            {
                paperCode = Convert.ToDouble(textBoxCode.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            aPaper.WritePaper(textBoxName.Text, paperCode, textBoxCooridinator.Text);

            if (form1.PaperIndex == -1)
            {
                _data.AddPaper(aPaper);
            }
            else
            {
                _data.UpdatePaper(form1.PaperIndex, aPaper);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            form1.PopulatePaper();
            Close();
        }

        public double incomingStudentID;
        private void btnAddStu_Click(object sender, EventArgs e)
        {
            FormSelectStudent fss = new FormSelectStudent(this);
            fss.ShowDialog();
        }

        private void btnDelStu_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxStudents.SelectedIndex;
            aPaper.RemoveStudentFromPaper(selectedIndex);
            listBoxStudents.DataSource = null;
            listBoxStudents.DataSource = aPaper.StudentsID;
        }

        public void AddIncomingStudent()
        {
            if (aPaper.IsStudentEnrolled(incomingStudentID) != true)
            {
                aPaper.EnrolStudent(incomingStudentID);
            }
            else
            {
                MessageBox.Show("This student already enrolled!");
            }
            listBoxStudents.DataSource = null;
            listBoxStudents.DataSource = aPaper.StudentsID;
        }
    }
}
