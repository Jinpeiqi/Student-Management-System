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
    public partial class FormStudent : Form
    {
        MainForm form1;
        public FormStudent(MainForm incomingForm)
        {
            form1 = incomingForm;
            InitializeComponent();
            LoadStudent();
        }

        Data _data = new Data();
        Students aStudent;
        public void LoadStudent()
        {
            if (form1.StudentIndex != -1)
            {
                List<Students> _studentsList = _data.GetStudentList();
                aStudent = _studentsList[form1.StudentIndex];
                textBoxFirstName.Text = aStudent.FirstName;
                textBoxLastName.Text = aStudent.LastName;
                textBoxId.Text = Convert.ToString(aStudent.StudentID);
                textBoxAddress.Text = aStudent.Address;
                aStudent.StudentHasPapersList = _data.FindPapersForStudent(aStudent.StudentID);
                listBoxPapers.DataSource = aStudent.StudentHasPapersList;
            }
            else
            {
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxId.Clear();
                textBoxAddress.Clear();
                listBoxPapers.DataSource = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double idNumber = 0;
            try
            {
                idNumber = Convert.ToDouble(textBoxId.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            aStudent = new Students(textBoxFirstName.Text, textBoxLastName.Text, idNumber, textBoxAddress.Text);
            if (form1.StudentIndex == -1)
            {
                _data.AddStudent(aStudent);
            }
            else
            {
                _data.UpdateStudent(form1.StudentIndex, aStudent);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            form1.PopulateStudent();
            Close();
        }
    }
}
