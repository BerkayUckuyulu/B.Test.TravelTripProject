using Seyahat.Models.Clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Seyahat.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        // GET: Blog
        BlogYorum blogYorum = new BlogYorum();
        public ActionResult Index()
        {
            blogYorum.Deger1 = context.Blogs.ToList();
            blogYorum.Deger3 = context.Blogs.OrderByDescending(x=>x.ID).Take(2);
            //var blogs =context.Blogs.ToList();
            return View(blogYorum);
        }
        
        public ActionResult BlogDetay(int id)
        {

            //var blogbul = context.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger1 = context.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.Deger2 = context.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(blogYorum);
        }
        
        //[HttpGet]
        //public PartialViewResult YorumYap(int id)
        //{
        //    ViewBag.value = id;
        //    return PartialView(ViewBag.value);
        //}
        //[HttpPost]
        //public PartialViewResult YorumYap(Yorumlar yorum)
        //{
        //    context.Yorumlars.Add(yorum);
        //    context.SaveChanges();
        //    return PartialView();
        //}
        public ActionResult YorumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YorumEkle(Yorumlar yorumlar)
        {
            context.Yorumlars.Add(yorumlar);
            context.SaveChanges();
            return View();
        }

    }
}