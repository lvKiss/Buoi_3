using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Buoi_3.Models;

namespace Buoi_3.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        BookManagerContext context = new BookManagerContext();
        public ActionResult ListBook()
        {
            
            var listBook = context.Books.ToList(); 
            return View(listBook);
        }
        [Authorize]

        public ActionResult Buy (int id)
        {
            
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            if(book==null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
     

        public ActionResult Create(Book book, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("ListBook");
            }

            return this.Create();
        }
        [Authorize]
        public ActionResult Details(int Id)
        {
            Book book = context.Books.First(x => x.ID == Id);
            return View(book);
        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            var b = context.Books.First(m => m.ID== id);
            return View(b);
        }
        [HttpPost]
      
        public ActionResult Edit(int id, FormCollection collection)
        {
            var b = context.Books.First(m => m.ID == id);
            if (b != null)
            {
                UpdateModel(b);
                context.SaveChanges();
                return RedirectToAction("ListBook");
            }
            return this.Edit(id);
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            var b = context.Books.First(m => m.ID == id);
            return View(b);
        }
     
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var b = context.Books.Where(x => x.ID== id).First();
            context.Books.Remove(b);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }

    }
}