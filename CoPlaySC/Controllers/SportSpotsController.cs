using CoPlaySC.Models;
using CoPlaySC.Models.DB;
using System;
using System.Collections.Generic;
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
        public ActionResult Search(AllSportTypes SportType)
        {
            if (SportType == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var results = from s in db.SportandRecs select s;
            if (!String.IsNullOrEmpty(SportType.Sports.ToString()))
            {
                string searchString = SportType.Sports.ToDisplayName().ToUpper();
                results = results.Where(s => s.SportsPlayed.ToUpper().Equals(searchString));
            }
            
            var preResult = new List<SportandRec>();
                if (results.Count() == 0)
                {
                    ViewBag.result = "No result found";
                    return View("Index");
                }
                else
                {
                    var count = 1;
 
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

        public  partial class JSONrs
        {
            public JSONrs(int Id, string PlaceName, string GeoLat, string GeoLong)
            {
                this.Id = Id;
                this.PlaceName = PlaceName;
                this.GeoLong = GeoLong;
                this.GeoLat = GeoLat;
            }
            public int Id { get; set; }
            public string PlaceName { get; set; }
            public string GeoLong { get; set; }
            public string GeoLat { get; set; }
        }
    }
}