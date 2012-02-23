using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcForAndy.Models;

namespace MvcForAndy.Controllers
{
    public class ListController : Controller
    {
        TrackyContext trackyDB = new TrackyContext();
        //
        // GET: /List/

        public ActionResult Index()
        {
            var items = trackyDB.Registrations.ToList();

            return View(items);
        }
    }
}
