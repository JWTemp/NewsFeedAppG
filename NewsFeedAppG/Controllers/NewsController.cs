using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewsFeedAppG.DAL;
using NewsFeedAppG.Models;
using System.Threading.Tasks;

namespace NewsFeedAppG.Controllers
{
    public class NewsController : Controller
    {
        private NewsFeedContext db = new NewsFeedContext();
        private const int defItemCount = 5;


        // GET: News
        public ActionResult Index(int? itemCount)
        {

            //DbHelper helper = new DbHelper();
            //return View(db.NewsItems.ToList().Take<NewsItem>(defItemCount));
            if (!itemCount.HasValue)
                itemCount = defItemCount;

            int totalItems;

            if (Request != null && Request.IsAjaxRequest())
            {
                int start = itemCount.Value - defItemCount;
                IEnumerable<NewsItem> pagedItems = db.NewsItems.ToList().GetRange(start, defItemCount);
                totalItems = db.NewsItems.Count();
                if (itemCount < totalItems)
                    AddMoreItemsToViewData(itemCount.Value);

                return View(pagedItems);
            }

            IEnumerable<NewsItem> items = db.NewsItems.ToList().GetRange(0, itemCount.Value);

            totalItems = db.NewsItems.Count();

            if (itemCount < totalItems)
                AddMoreItemsToViewData(itemCount.Value);

            return View(items);

        }

        // GET: News/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsItem newsItem = db.NewsItems.Find(id);
            if (newsItem == null)
            {
                return HttpNotFound();
            }
            return View(newsItem);
        }

        // GET: News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: News/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,title,link,description,author,image,image_caption")] NewsItem newsItem)
        {
            if (ModelState.IsValid)
            {
                db.NewsItems.Add(newsItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newsItem);
        }

        // GET: News/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsItem newsItem = db.NewsItems.Find(id);
            if (newsItem == null)
            {
                return HttpNotFound();
            }
            return View(newsItem);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,title,link,description,author,image,image_caption")] NewsItem newsItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newsItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newsItem);
        }

        // GET: News/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsItem newsItem = db.NewsItems.Find(id);
            if (newsItem == null)
            {
                return HttpNotFound();
            }
            return View(newsItem);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewsItem newsItem = db.NewsItems.Find(id);
            db.NewsItems.Remove(newsItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private void AddMoreItemsToViewData(int itemCount)
        {
            ViewData["moreNews"] = Url.Action("Index", "News", new { itemCount = itemCount + defItemCount });
        }
    }
}
