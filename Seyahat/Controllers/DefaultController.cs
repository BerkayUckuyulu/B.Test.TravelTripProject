using Moq;
using Seyahat.Models.Clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seyahat.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context context = new Context();
        public ActionResult Index()
        {
            
            var degerler = context.Blogs.OrderByDescending(x=>x.ID).Take(5).ToList();
            
               
            return View(degerler);
            
        }
        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult Partial1()
        {
           
            var degerler = context.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = context.Blogs.ToList();
            int degerinId = degerler.Count - 2;
            var deger = context.Blogs.Where(x => x.ID == degerinId).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3EnPopuler5Blog()
        {
            var values = context.Blogs.OrderByDescending(x => x.ID).Take(5).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4EniyiYer1()
        {
            var values = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4EniyiYer2()
        {
            List<Blog> blogs = context.Blogs.ToList();
            var values2 = blogs.OrderByDescending(x => x.ID).ToList();
            var values3 = values2.GetRange(3, 3).Take(3);
            
            return PartialView(values3);
        }

       


    }
}