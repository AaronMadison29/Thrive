using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThriveAPP.Services;
using ThriveAPP.Models;
using ThriveAPP.Contracts;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace ThriveAPP.Controllers
{
    public class StudentController : Controller
    {
        private readonly IEmailServices _emailService;
        private readonly IMessengerServices _messengerService;
        private readonly ISchoolServices _schoolService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHubContext<MessengerService> _hubContext;

        public StudentController(UserManager<IdentityUser> userManager, IEmailServices emailService, IMessengerServices messengerService, ISchoolServices schoolService, IHubContext<MessengerService> hubContext)
        {
            _emailService = emailService;
            _messengerService = messengerService;
            _schoolService = schoolService;
            _userManager = userManager;
            _hubContext = hubContext;
        }

        // GET: Student
        public async Task<ActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var student = await _schoolService.GetStudent(userId);
            ViewBag.teachers = await _schoolService.GetTeachersAsync();
            return View(student);
        }

        public IActionResult Chat()
        {
            return View();

        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            var student = new Student();
            return View(student);
        }

        // POST: Teacher/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _schoolService.LinkStudentAccount(student);

                    //EDIT STUDENT IN API DB HERE
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(student);
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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