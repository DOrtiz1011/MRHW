using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AdDataSite.AdDataService;

namespace AdDataSite.Controllers
{
    public class AdDataController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        private List<Ad> GetAdData()
        {
            return new AdDataServiceClient().GetAdDataByDateRange(new DateTime(2011, 1, 1), new DateTime(2011, 4, 1));
        }

        public ActionResult List1_AllAds()
        {
            ViewBag.title = "All Ads";
            return View("AllColsTable", GetAdData().OrderBy(x => x.Brand.BrandName).ToList());
        }

        public ActionResult List2_CoverAds()
        {
            ViewBag.title = "All Cover";
            return View("AllColsTable", GetAdData().Where(x => x.Position == "Cover" && x.NumPages >= 0.5m).OrderBy(x => x.Brand.BrandName).ToList());
        }
    }
}
