using CoPlaySC.Models;
using CoPlaySC.Models.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CoPlaySC.Controllers
{
    public class SportSpotsController : Controller
    {
        private coplayDBEntities db = new coplayDBEntities();
        // GET: SportandRecs/Details/5
        public ActionResult Search(ModelForSearchPage model)
        {
            if (model == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var results = from s in db.SportandRecs select s;
            //Prepare searching string
            if (!String.IsNullOrEmpty(model.Sports.Sports.ToString()) && !String.IsNullOrEmpty(model.Suburbs.Suburbs.ToString()))
            {
                if (model.Suburbs.Suburbs.ToString().Equals("CURRENT"))
                {
                    //For now
                    return View("Index");
                }
                else
                {
                    string searchSportString = model.Sports.Sports.ToDisplayName().ToUpper();
                    string searchSuburbString = model.Suburbs.Suburbs.ToDisplayName().ToUpper();

                    results = results.Where(s => s.SportsPlayed.ToUpper().Equals(searchSportString) && s.SuburbTown.ToUpper().Equals(searchSuburbString));
                }
            }
            //Prepare result
            var preResult = new List<SportandRec>();
            if (results.Count() == 0)
            {
                ViewBag.result = "No result found";
                return View("Index");
            }
            else
            {
                foreach (SportandRec element in results)
                {
                    preResult.Add(element);
                }
            }
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(preResult);
            ViewBag.result = json;
            return View("Index");
        }


        // GET: SportSpots
        public ActionResult Index()
        {
            return View();
        }
    }
}