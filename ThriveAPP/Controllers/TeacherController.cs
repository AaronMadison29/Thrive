using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThriveAPP.Models;
using ThriveAPP.Services;
using ThriveAPP.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace ThriveAPP.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IEmailServices _emailService;
        private readonly IMessengerServices _messengerService;
        private readonly ISchoolServices _schoolService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHubContext<MessengerService> _hubContext;


        public TeacherController(UserManager<IdentityUser> userManager, IEmailServices emailService, IMessengerServices messengerService, ISchoolServices schoolService, IHubContext<MessengerService> hubContext)
        {
            _emailService = emailService;
            _messengerService = messengerService;
            _schoolService = schoolService;
            _userManager = userManager;
            _hubContext = hubContext;
        }

        // GET: Teacher
        public async Task<ActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var teacher = await _schoolService.GetTeacher(userId);
            var students = await _schoolService.GetStudentsInClassAsync(teacher.Class.ClassId);
            ViewBag.students = students;
            ViewBag.teachers = await _schoolService.GetTeachersAsync();

            await _hubContext.Clients.All.SendAsync("connected", teacher.Email);

            return View(teacher);
        }

        public IActionResult Chat()
        {
            return View();
        }

        // GET: Teacher/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var student = await _schoolService.GetStudent(id);
            return View(student);
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            var teacher = new Teacher();
            return View(teacher);
        }

        // POST: Teacher/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Teacher teacher)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //EDIT TEACHER IN API DB HERE
                    await _schoolService.LinkTeacherAccount(teacher);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(teacher);
            }
        }

        // GET: Teacher/Edit/5
        public async Task<ActionResult> EditStudentProfile(int id)
        {
            var studentFromDb = await _schoolService.GetStudent(id);
            var grades = await _schoolService.GetStudentClassGradesAysnc();
            ViewBag.Grades = grades.Where(a => a.StudentId == id).ToList();
            return View(studentFromDb);
        }

        // POST: Teacher/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditStudentProfile(Profile profile)
        {
            try
            {
                await _schoolService.EditStudentProfile(profile.ProfileId, profile);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Teacher/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}