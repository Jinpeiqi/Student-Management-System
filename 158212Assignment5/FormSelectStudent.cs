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
    public partial class FormSelectStudent : Form
    {
        FormPaper _formPaper;
        Data _Data = new Data();
        List<Students> tempList = new List<Students>();

        public FormSelectStudent(FormPaper incomingForm)
        {
            _formPaper = incomingForm;

            InitializeComponent();

            tempList = _Data.GetStudentList();
            listBoxStudents.DataSource = tempList;
        }

        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            _formPaper.AddIncomingStudent();
            Close();
        }

        private int studentIndex;
        private double selectedStudentID;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                studentIndex = listBoxStudents.SelectedIndex;
                selectedStudentID = tempList[studentIndex].StudentID;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            _formPaper.incomingStudentID = selectedStudentID;
            textBoxID.Text = Convert.ToString(selectedStudentID);
        }
    }
}
