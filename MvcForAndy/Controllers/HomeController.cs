using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForAndy.Models;

namespace MvcForAndy.Controllers
{
    public class HomeController : Controller
    {
        TrackyContext trackyDB = new TrackyContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Do. And be you.<br />Personal to-dos. Professional projects. Social circles.  Manage them all with Tracky.";

            return View(new Registration());
        }

        //
        // POST: /Home/

        [HttpPost]
        public PartialViewResult Index(Registration model)
        {
            if (ModelState.IsValid)
            {
                var item = new Registration
                {
                    Email = model.Email
                };
                trackyDB.Registrations.Add(item);
                trackyDB.SaveChanges();

                return PartialView("Success", model);
            }
            else
            {
                // If we got this far, something failed, redisplay form
                return PartialView(model);
            }
        }

    }
}
