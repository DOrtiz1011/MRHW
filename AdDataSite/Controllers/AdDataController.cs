using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdDataSite.AdDataService;
using AdDataSite.Models;

namespace AdDataSite.Controllers
{
    public class AdDataController : Controller
    {
        IEnumerable<Ad> adData;

        public AdDataController()
        {
            try
            {
                adData = new AdDataServiceClient().GetAdDataByDateRange(new DateTime(2011, 1, 1), new DateTime(2011, 2, 1));
            }
            catch
            {
                throw;
            }
        }
        // GET: AdData
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult List1_AllAds()
        {
            ViewBag.id = "allData";
            ViewBag.title = "All ads";

            var models = adData.OrderBy(ad => ad.Brand.BrandName);

            return PartialView("List1_AllAds", models);
        }
    }
}
