using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCBlogLab.Models;
using MVCBlogLab.Services;

namespace MVCBlogLab.Controllers
{
    public class MessageController : Controller
    {
        messageDBService data = new messageDBService();

        // GET: Message
        public ActionResult Index()
        {
            return View(data.GetData());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string ArticleTitle, string Content)
        {
            data.DBCreate(ArticleTitle, Content);
            return RedirectToAction("Index");
        }
    }
}