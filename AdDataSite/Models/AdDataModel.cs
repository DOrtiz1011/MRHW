using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AdDataSite.AdDataService;

namespace AdDataSite.Models
{
    public class AdDataModel : IAdDataService
    {
        Ad[] IAdDataService.GetAdDataByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        Task<Ad[]> IAdDataService.GetAdDataByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}