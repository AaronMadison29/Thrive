using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ThriveAPP.Contracts;
using ThriveAPP.Models;

namespace ThriveAPP.Services
{
    public class SchoolService : ISchoolServices
    {
        private readonly ISchoolServices _schoolService;

        public SchoolService(ISchoolServices schoolService)
        {
            _schoolService = schoolService;
        }

        public async Task AddTeacher(Teacher teacher)
        {
            string json = JsonConvert.SerializeObject(teacher);

            HttpClient client = new HttpClient();

            client.BaseAddress = ""

        }
    }
}
