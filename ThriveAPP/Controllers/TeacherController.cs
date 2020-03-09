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

namespace ThriveAPP.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IEmailServices _emailService;
        private readonly IMessengerServices _messengerService;
        private readonly ISchoolServices _schoolService;
        private readonly UserManager<IdentityUser> _userManager;

        public TeacherController(UserManager<IdentityUser> userManager, IEmailServices emailService, IMessengerServices messengerService, ISchoolServices schoolService)
        {
            _emailService = emailService;
            _messengerService = messengerService;
            _schoolService = schoolService;
            _userManager = userManager;
        }

        // GET: Teacher
        public async Task<ActionResult> Index()
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var teacher = await _schoolService.GetTeacher(userId);
                return View(teacher);
            }
            else
            {
                return View();
            }
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                    var user = _userManager.FindByIdAsync(this.User.FindFirst(ClaimTypes.NameIdentifier).Value).Result;
                    teacher.UserId = user.Id;
                    teacher.Email = user.Email;
                    await _schoolService.AddTeacherAsync(teacher);
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
            var profileFromDb = studentFromDb.Profile;
            return View(profileFromDb);
        }

        // POST: Teacher/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditStudentProfile(int id, Profile profile)
        {
            try
            {
                await _schoolService.EditStudentProfile(id, profile);
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