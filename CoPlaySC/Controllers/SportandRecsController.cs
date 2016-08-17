using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoPlaySC.Models.DB;

namespace CoPlaySC.Controllers
{
    public class SportandRecsController : Controller
    {
        private coplayDBEntities db = new coplayDBEntities();

        // GET: SportandRecs
        public ActionResult Index()
        {
            return View(db.SportandRecs.ToList());
        }

        // GET: SportandRecs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SportandRec sportandRec = db.SportandRecs.Find(id);
            if (sportandRec == null)
            {
                return HttpNotFound();
            }
            return View(sportandRec);
        }

        // GET: SportandRecs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SportandRecs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "X,Y,OBJECTID,Facility_ID,FacilityName,StreetNo,StreetName,StreetType,SuburbTown,Postcode,Latitude,Longitude,FaciltySportPlayedID,SportsPlayed,NumberFieldCourts,FieldSurfaceType,FacilityAge,FacilityCondition,FacilityUpgradeAge,Changerooms,LGA")] SportandRec sportandRec)
        {
            if (ModelState.IsValid)
            {
                db.SportandRecs.Add(sportandRec);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sportandRec);
        }

        // GET: SportandRecs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SportandRec sportandRec = db.SportandRecs.Find(id);
            if (sportandRec == null)
            {
                return HttpNotFound();
            }
            return View(sportandRec);
        }

        // POST: SportandRecs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "X,Y,OBJECTID,Facility_ID,FacilityName,StreetNo,StreetName,StreetType,SuburbTown,Postcode,Latitude,Longitude,FaciltySportPlayedID,SportsPlayed,NumberFieldCourts,FieldSurfaceType,FacilityAge,FacilityCondition,FacilityUpgradeAge,Changerooms,LGA")] SportandRec sportandRec)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sportandRec).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sportandRec);
        }

        // GET: SportandRecs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SportandRec sportandRec = db.SportandRecs.Find(id);
            if (sportandRec == null)
            {
                return HttpNotFound();
            }
            return View(sportandRec);
        }

        // POST: SportandRecs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SportandRec sportandRec = db.SportandRecs.Find(id);
            db.SportandRecs.Remove(sportandRec);
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
