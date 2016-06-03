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
        private DateTime StartDate = new DateTime(2011, 1, 1);
        private DateTime EndDate = new DateTime(2011, 4, 1);

        GetAdDataByDateRangeResponse IAdDataService.GetAdDataByDateRange(GetAdDataByDateRangeRequest request)
        {
            throw new NotImplementedException();
        }

        Task<GetAdDataByDateRangeResponse> IAdDataService.GetAdDataByDateRangeAsync(GetAdDataByDateRangeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
