﻿using System;
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
    public class CouponsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Coupons
        public ActionResult Index()
        {
            var coupons = db.Coupons.Include(c => c.User);
            return View(coupons.ToList());
        }

        // GET: Coupons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coupons coupons = db.Coupons.Find(id);
            if (coupons == null)
            {
                return HttpNotFound();
            }
            return View(coupons);
        }

        // GET: Coupons/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email");
            return View();
        }

        // POST: Coupons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GS1Data,CouponNum,DropDate,Expiration,Value,Quantity,UPC,FreeItem,FreeItem2,UserId")] Coupons coupons)
        {
            if (ModelState.IsValid)
            {
                db.Coupons.Add(coupons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", coupons.UserId);
            return View(coupons);
        }

        // GET: Coupons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coupons coupons = db.Coupons.Find(id);
            if (coupons == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", coupons.UserId);
            return View(coupons);
        }

        // POST: Coupons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GS1Data,CouponNum,DropDate,Expiration,Value,Quantity,UPC,FreeItem,FreeItem2,UserId")] Coupons coupons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coupons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", coupons.UserId);
            return View(coupons);
        }

        // GET: Coupons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coupons coupons = db.Coupons.Find(id);
            if (coupons == null)
            {
                return HttpNotFound();
            }
            return View(coupons);
        }

        // POST: Coupons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Coupons coupons = db.Coupons.Find(id);
            db.Coupons.Remove(coupons);
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
