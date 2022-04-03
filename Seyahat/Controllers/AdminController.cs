using Seyahat.Models.Clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seyahat.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context context = new Context();
        public ActionResult Index()
        {
            var deger = context.Blogs.OrderByDescending(x => x.ID).ToList();
            return View(deger);
        }
        public ActionResult BlogEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult BlogEkle(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();

            return RedirectToAction("Index","Admin");
        }
        public ActionResult BlogSil(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index", "Admin");

        }
        public ActionResult BlogGetir(int id)
        {
            var blog = context.Blogs.Find(id);
            return View(blog);
        }
        public ActionResult BlogGuncelle(Blog blog)
        {
            var blog2 = context.Blogs.Find(blog.ID);
            blog2.Aciklama = blog.Aciklama;
            blog2.Baslik = blog.Baslik;
            blog2.BlogImage = blog.BlogImage;
            blog2.Tarih = blog.Tarih;
            context.SaveChanges();
            return RedirectToAction("Index","Admin");

        }
        

        
        

    }
}