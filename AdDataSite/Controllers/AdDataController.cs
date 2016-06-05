using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AdDataSite.AdDataService;
using AdDataSite.Models;

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
            var adData = GetAdData().OrderBy(x => x.Brand.BrandName).ToList();

            return View("AllColsAdsTable", adData);
        }

        public ActionResult List2_CoverAds()
        {
            ViewBag.title = "All Cover Ads";
            var adData = GetAdData().Where(x => x.Position == "Cover" && x.NumPages >= 0.5m).OrderBy(x => x.Brand.BrandName).ToList();

            return View("AllColsAdsTable", adData);
        }

        public ActionResult List3_Top5AdsByCoverageAndBrand()
        {
            ViewBag.title = "Top 5 Ads By Coverage and Brand";

            var adData = GetAdData().GroupBy(x => new { numPages = x.NumPages, brand = x.Brand.BrandName })
                .OrderByDescending(x => x.Key.numPages)
                .ThenBy(x => x.Key.brand)
                .Take(5)
                .Select(x => x.First())
                .ToList();

            return View("AllColsAdsTable", adData);
        }

        public ActionResult List4_TopBrandsByCoverage()
        {
            ViewBag.title = "Top 5 Brands by Coverage Amount";

            var adData = GetAdData()
                .GroupBy(ad => ad.Brand.BrandName)
                .Select(x => new { brand = x.Key, totalCoverage = x.Sum(g => g.NumPages) })
                .OrderByDescending(g => g.totalCoverage)
                .ThenBy(g => g.brand)
                .Select(g => new { g.brand, g.totalCoverage })
                .Take(5);

            var BrandViewModelList = new List<BrandViewModel>();

            foreach (var a in adData)
            {
                BrandViewModelList.Add(new BrandViewModel() { BrandName = a.brand, TotalCoverage = a.totalCoverage });
            }

            return PartialView("AllColsBrandsTable", BrandViewModelList);
        }
    }
}
