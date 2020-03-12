using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ThriveAPP.ActionFilters
{
    public class GlobalRouting : IActionFilter

    {
        private readonly ClaimsPrincipal _claimsPrincipal;
        public GlobalRouting(ClaimsPrincipal claimsPrincipal)
        {
            _claimsPrincipal = claimsPrincipal;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            var action = context.RouteData.Values["action"];
            if (controller.Equals("Home") && action.Equals("Index"))
            {
                if (_claimsPrincipal.IsInRole("Teacher"))
                {
                    context.Result = new RedirectToActionResult("Index", "Teacher", null);
                }
                else if (_claimsPrincipal.IsInRole("Student"))
                {
                    context.Result = new RedirectToActionResult("Index", "Student", null);
                }
                else if (_claimsPrincipal.IsInRole("Parent"))
                {
                    context.Result = new RedirectToActionResult("Index", "Parent", null);
                }
            }
        }
    }
}
