using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ThriveAPP.Contracts;
using ThriveAPP.Data;
using ThriveAPP.Models;

namespace ThriveAPP.Services
{
    public class SchoolService : ISchoolServices
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;

        public SchoolService(IConfiguration config, ApplicationDbContext context)
        {
            _config = config;
            _context = context;
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
    }
}
