using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PullStudentData.Models;
using System.IO;

namespace PullStudentData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                string token = textToken.Text;
                string courseNum = textCourseNum.Text;

                StudentDataRequest request = new StudentDataRequest(token, courseNum);
                List<string> students = getData(request);
                createCSV(students);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<string> getData(StudentDataRequest request)
        {
            labelStatus.Text = "Getting data...";
            return request.getAll(ref labelStatus);
        }


        private void createCSV(List<string> students)
        {
            StreamWriter sw = new StreamWriter("output.csv");
            try
            {
                labelStatus.Text = "Saving data...";
                sw.WriteLine("StudentID,StudentName");

                foreach (string student in students)
                {
                    sw.WriteLine(student);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Close();
                labelStatus.Text = "Ready!";
            }
        }
    }
}
