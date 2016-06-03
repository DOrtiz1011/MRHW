using System;
using System.Threading.Tasks;
using WebApplication1.AdDataService;

namespace WebApplication1.Models
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