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

namespace ThriveAPP.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IEmailServices _emailService;
        private readonly IMessengerServices _messengerService;
        private readonly ISchoolServices _schoolService;

        public TeacherController(IEmailServices emailService, IMessengerServices messengerService, ISchoolServices schoolService)
        {
            _emailService = emailService;
            _messengerService = messengerService;
            _schoolService = schoolService;
        }

        // GET: Teacher
        public ActionResult Index()
        {
            //_messengerService.GetUsers();

            return View();
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
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    teacher.UserId = userId;
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Teacher/Edit/5
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