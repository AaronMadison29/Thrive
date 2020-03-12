using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ThriveAPP.Contracts;
using ThriveAPP.Models;
using Twilio.Types;

namespace ThriveAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailServices _emailService;
        private readonly IMessengerServices _messengerService;
        private readonly ISchoolServices _schoolService;
        private readonly ISmsServices _smsService;

        public HomeController(ILogger<HomeController> logger, IEmailServices emailServices, IMessengerServices messengerServices, ISchoolServices schoolServices, ISmsServices smsServices)
        {
            _logger = logger;
            _emailService = emailServices;
            _messengerService = messengerServices;
            _schoolService = schoolServices;
            _smsService = smsServices;

        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> ScanSystem()
        {
            var studentClassGrades = await _schoolService.GetStudentClassGradesAysnc();
            var teachers = await _schoolService.GetTeachersAsync();
            var parents = await _schoolService.GetParentsAsync();

            var problemStudents = new List<Student>();
            var parentsWithProblemStudents = new List<Parent>();
            var teachersWithProblemStudents = new List<Teacher>();

            foreach (var studentClassGrade in studentClassGrades)
            {
                if(studentClassGrade.Grade <= 50)
                {
                    problemStudents.Add(studentClassGrade.Student);
                    if(!teachersWithProblemStudents.Exists(t => t.ClassId == studentClassGrade.ClassId))
                    {
                        teachersWithProblemStudents.Add(teachers.Find(t=> t.ClassId == studentClassGrade.ClassId));
                    }
                    if (!parentsWithProblemStudents.Exists(p => p.StudentId == studentClassGrade.StudentId))
                    {
                        parentsWithProblemStudents.Add(parents.Find(p => p.StudentId == studentClassGrade.StudentId));
                    }
                }
                else if (studentClassGrade.Grade <= 70)
                {
                    if(studentClassGrade.Student.Profile.FavoriteSubject == studentClassGrade.Class.Subject)
                    {
                        problemStudents.Add(studentClassGrade.Student);
                        if (!teachersWithProblemStudents.Exists(t => t.ClassId == studentClassGrade.ClassId))
                        {
                            teachersWithProblemStudents.Add(teachers.Find(t => t.ClassId == studentClassGrade.ClassId));
                        }
                        if (!parentsWithProblemStudents.Exists(p => p.StudentId == studentClassGrade.StudentId))
                        {
                            parentsWithProblemStudents.Add(parents.Find(p => p.StudentId == studentClassGrade.StudentId));
                        }
                    }
                }
            }
            
            var recipients = new List<IEmail>();
            recipients.AddRange(parentsWithProblemStudents);
            recipients.AddRange(teachersWithProblemStudents);

            await _emailService.EmailAlertAsync(recipients);

            return View(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
