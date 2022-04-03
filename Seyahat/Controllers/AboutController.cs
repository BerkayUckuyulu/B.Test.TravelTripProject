using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyahat.Models.Clasess;

namespace Seyahat.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context context = new Context();

        public ActionResult Index()
        {
            var result = context.Hakkımızdas.ToList(); 
            return View(result);
        }
    }
}