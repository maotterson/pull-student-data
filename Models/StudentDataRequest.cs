using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using PullStudentData.Models;
using Newtonsoft.Json;

namespace PullStudentData.Models
{
    class StudentDataRequest
    {
        static HttpClient httpClient = new HttpClient();
        string uri = "";

        public StudentDataRequest(string token, string courseNum)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            uri = $"https://canvas.lorainccc.edu/api/v1/courses/{courseNum}/users?enrollment_type=student&per_page=100"; 
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            
        }

        public List<String> getAll(ref System.Windows.Forms.Label statusLabel)
        {
            List<String> students = new List<String>();
            int currentPage = 1;
            while (true)
            {
                statusLabel.Text = "Working... " + currentPage;
                List<String> currentStudents = getOnce(currentPage);
                if(currentStudents == null || currentPage==10)
                {
                    break;
                }
                else
                {
                    students.AddRange(currentStudents);
                    currentPage++;
                }
            }
            return students;
        }

        public List<String> getOnce(int pageNumber = 1)
        {
            List<String> students = new List<String>();
            HttpResponseMessage response = httpClient.GetAsync(uri).Result;
            string requestUri = uri + "?page=" + pageNumber;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result; 
                List<Student> studentList = JsonConvert.DeserializeObject<List<Student>>(result);
                foreach(Student student in studentList)
                {
                    students.Add($"{student.sis_user_id},{student.name}");
                }
                return students;
            }
            else
            {
                return null;
            }
        }
    }
}
