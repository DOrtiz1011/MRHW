using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AdDataSite.AdDataService;

namespace AdDataSite.Controllers
{
    public class AdDataController : Controller
    {

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
            
            ViewBag.title = "All ads";

            var adData = new AdDataServiceClient().GetAdDataByDateRange(new DateTime(2011, 1, 1), new DateTime(2011, 4, 1)).OrderBy(x => x.Brand.BrandName).ToList();

            return View("List1_AllAds", adData);
        }
    }
}
