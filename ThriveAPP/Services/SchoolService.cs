using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ThriveAPP.Contracts;
using ThriveAPP.Models;

namespace ThriveAPP.Services
{
    public class SchoolService : ISchoolServices
    {
        private readonly IConfiguration _config;


        public SchoolService(IConfiguration config)
        {
            _config = config;
        }

        public async Task AddTeacherAsync(Teacher teacher)
        {
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += "api/Teacher";
            var json = JsonConvert.SerializeObject(teacher);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            HttpResponseMessage response = await client.PostAsync(url,data);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
            }
        }

        public async Task AddParentAsync(Parent parent)
        {
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += "api/Parent";
            var json = JsonConvert.SerializeObject(parent);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            HttpResponseMessage response = await client.PostAsync(url, data);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
            }
        }

        public async Task AddStudentAsync(Student student)
        {
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += "api/Student";
            var json = JsonConvert.SerializeObject(student);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            HttpResponseMessage response = await client.PostAsync(url, data);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<Teacher> GetTeacher(string userId)
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Teacher/{userId}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Teacher>(json);
            }
            return null;
        }
        public async Task<Teacher> GetTeacher(int id)
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Teacher/{id}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Teacher>(json);
            }
            return null;
        }
        public async Task<Teacher> GetTeacherByClassAsync(int classId)
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Teacher/class/{classId}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Teacher>(json);
            }
            return null;
        }
        public async Task<List<Teacher>> GetTeachersAsync()
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Teacher";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Teacher>>(json);
            }
            return null;
        }

        public async Task<Parent> GetParent(string userId)
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Parent/{userId}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Parent>(json);
            }
            return null;
        }
        public async Task<Parent> GetParent(int id)
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Parent/{id}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Parent>(json);
            }
            return null;
        }
        public async Task<List<Parent>> GetParentsAsync()
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Parent";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Parent>>(json);
            }
            return null;
        }

        public async Task<Student> GetStudent(string userId)
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Student/{userId}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Student>(json);
            }
            return null;
        }

        public async Task<Student> GetStudent(int id)
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Student/{id}";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Student>(json);
            }
            return null;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Student";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Student>>(json);
            }

            return null;
        }

        public async Task<List<StudentClassGrade>> GetStudentClassGradesAysnc()
        {
            HttpClient client = new HttpClient();
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/StudentClassGrades";
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<StudentClassGrade>>(json);
            }
            return null;
        }

        public async Task EditStudentProfile(int id, Profile profile)
        {
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Student/{id}";
            var json = JsonConvert.SerializeObject(profile);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            HttpResponseMessage response = await client.PutAsync(url, data);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
            }
        }
        public async Task LinkTeacherAccount(Teacher teacher)
        {
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Teacher";
            var json = JsonConvert.SerializeObject(teacher);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            HttpResponseMessage response = await client.PutAsync(url, data);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
            }
        }

        public async Task LinkStudentAccount(Student student)
        {
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/student/link/{student.StudentId}";
            var json = JsonConvert.SerializeObject(student);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            HttpResponseMessage response = await client.PutAsync(url, data);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
            }
        }

        public async Task LinkParentAccount(Parent parent)
        {
            string url = _config.GetValue<string>("ApiHostUrl:BaseUrl");
            url += $"api/Parent";
            var json = JsonConvert.SerializeObject(parent);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();

            HttpResponseMessage response = await client.PutAsync(url, data);

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
            }
        }
    }
}
