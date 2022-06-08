using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class examController : Controller
    {
        //
        // GET: /exam/
        public ActionResult xam()
        {
            return View();
        }
        public ActionResult paperdb()
        {
            return View();
        }
        public ActionResult quest()
        {
            return View();
        }


        [HttpPost]
        public ActionResult paperdb(paper userdata)
        {
           using ( online_examEntities db = new online_examEntities())
           {
               db.papers.Add(userdata);
               db.SaveChanges();
               ViewBag.Result = "inserted sucessfully";
               ModelState.Clear();


           }

           return View(new paper());
        }
        public ActionResult quest(question userQ)
        {
            using (online_examEntities db = new online_examEntities())
            {
                db.questions.Add(userQ);
                db.SaveChanges();
                ViewBag.Result = "inserted sucessfully";
                ModelState.Clear();


            }

            return View(new question());
        }



	}
}