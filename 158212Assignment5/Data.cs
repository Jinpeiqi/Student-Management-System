
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _University;

namespace _158212Assignment5
{
    class Data
    {
        static List<Students> studentsList = new List<Students>(); 
        static List<Papers> papersList = new List<Papers>();

        public List<Students> GetStudentList()
        {
            return studentsList;
        }

        public List<Papers> GetPapersList()
        {
            return papersList;
        }

        public void DeleteAllList()
        {
            studentsList.Clear();
            papersList.Clear();
        }

        public void AddStudent(Students student)
        {
            studentsList.Add(student);
        }

        public void AddPaper(Papers paper)
        {
            papersList.Add(paper);
        }

        public void UpdateStudent(int index, Students student)
        {
            studentsList[index] = student;
        }

        public void UpdatePaper(int index, Papers paper)
        {
            papersList[index] = paper;
        }

        public int CountStudentsList()
        {
            return studentsList.Count;
        }

        public int CountPapersList()
        {
            return papersList.Count;
        }

        public List<double> FindPapersForStudent(double studentID)
        {
            List<double> papersAStudentEnrolled = new List<double>();
            foreach (var paper in papersList)
            {
                double paperCode = paper.PaperCode;
                foreach (double id in paper.StudentsID)
                {
                    if (id == studentID)
                    { papersAStudentEnrolled.Add(paperCode); }
                }
            }
            return papersAStudentEnrolled;
        }

        public void UpdatsStudentsList()
        {
            List<Students> tempStudentsList = new List<Students>();
            Students tempStu;
            foreach (Students stu in studentsList)
            {
                tempStu = stu;
                tempStu.StudentHasPapersList = FindPapersForStudent(stu.StudentID);
                tempStudentsList.Add(tempStu);
            }
            studentsList = tempStudentsList;
        }

        public string PrintStudent(List<Students> studentList, int index)
        {
            Students tempStu = studentsList[index];
            string strPaper = "";
            foreach (double d in tempStu.StudentHasPapersList)
            {
                strPaper = strPaper + Convert.ToString(d) + ",";
            }
            return string.Format("{0}|{1}|{2:N}|{3}|{4}", tempStu.FirstName, tempStu.LastName,tempStu.StudentID,tempStu.Address,strPaper);
        }

        public string PrintPaper(List<Papers> papersList, int index)
        {
            Papers tempPaper = papersList[index];
            string strStu = "";
            foreach (double d in tempPaper.StudentsID)
            {
                strStu = strStu + Convert.ToString(d) + ",";
            }
            return string.Format("*{0}|{1:N}|{2}|{3}", tempPaper.Name, tempPaper.PaperCode, tempPaper.Cooridinator, strStu);
        }
    }
}
