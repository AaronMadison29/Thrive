using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ThriveAPP.Contracts;
using ThriveAPP.Models;
using ThriveAPP.Services;

namespace ThriveAPP.Controllers
{
    public class ParentController : Controller
    {
        private readonly IEmailServices _emailService;
        private readonly IMessengerServices _messengerService;
        private readonly ISchoolServices _schoolService;
        private readonly UserManager<IdentityUser> _userManager;

        public ParentController(UserManager<IdentityUser> userManager, IEmailServices emailService, IMessengerServices messengerService, ISchoolServices schoolService)
        {
            _emailService = emailService;
            _messengerService = messengerService;
            _schoolService = schoolService;
            _userManager = userManager;
        }

        // GET: Parent
        public async Task<ActionResult> Index()
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var parent = await _schoolService.GetParent(userId);
                return View(parent);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Chat()
        {
            return View();

        }

        // GET: Parent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            var parent = new Parent();
            return View(parent);
        }

        // POST: Teacher/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Parent parent)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    await _schoolService.LinkParentAccount(parent);

                    //EDIT PARENT IN API DB HERE
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(parent);
            }
        }

        // GET: Parent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Parent/Edit/5
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

        // GET: Parent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Parent/Delete/5
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