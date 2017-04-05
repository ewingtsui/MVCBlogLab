using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBlogLab.Models;

namespace MVCBlogLab.Services
{
    public class messageDBService
    {
        public messageEntities db = new messageEntities();

        public List<Article> GetData()
        {
            return db.Article.ToList();
        }

        public void DBCreate(string ArticleTitle, string Content)
        {
            Article NewData = new Article();

            NewData.Title = ArticleTitle;
            NewData.Content = Content;
            NewData.time = DateTime.Now;

            db.Article.Add(NewData);
            db.SaveChanges();
        }
    }
}