using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CECv3.Models;

namespace CECv3.Controllers
{
    public class RetailController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Retail
        public ActionResult Index()
        {
            //var acctDetails = db.AcctDetails.Include(a => a.User);
            var acctDetails = db.AcctDetails.Include(a => a.User).Where(p => p.AccountType == "Retail");
            return View(acctDetails.ToList());
        }

        // GET: Retail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcctDetails acctDetails = db.AcctDetails.Find(id);
            if (acctDetails == null)
            {
                return HttpNotFound();
            }
            return View(acctDetails);
        }

        // GET: Retail/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email");
            return View();
        }

        // POST: Retail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AccountType,AcctNumber,Name,ShortName,StoreNum,Address1,Address2,City,State,ZipCode,RedemptionFees,Approval,ContactName,ContactPhone,Email,ACHBankName,ACHRouting,ACHAccount,UserId")] AcctDetails acctDetails)
        {
            if (ModelState.IsValid)
            {
                db.AcctDetails.Add(acctDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", acctDetails.UserId);
            return View(acctDetails);
        }

        // GET: Retail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcctDetails acctDetails = db.AcctDetails.Find(id);
            if (acctDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", acctDetails.UserId);
            return View(acctDetails);
        }

        // POST: Retail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AccountType,AcctNumber,Name,ShortName,StoreNum,Address1,Address2,City,State,ZipCode,RedemptionFees,Approval,ContactName,ContactPhone,Email,ACHBankName,ACHRouting,ACHAccount,UserId")] AcctDetails acctDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acctDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", acctDetails.UserId);
            return View(acctDetails);
        }

        // GET: Retail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcctDetails acctDetails = db.AcctDetails.Find(id);
            if (acctDetails == null)
            {
                return HttpNotFound();
            }
            return View(acctDetails);
        }

        // POST: Retail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AcctDetails acctDetails = db.AcctDetails.Find(id);
            db.AcctDetails.Remove(acctDetails);
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
    }
}
