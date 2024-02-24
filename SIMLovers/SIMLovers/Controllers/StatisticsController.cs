using Microsoft.AspNetCore.Mvc;
using SIMLovers.Core.Contacts;
using SIMLovers.Models.Statistic;

namespace SIMLovers.Controllers
{
    public class StatisticsController : Controller
    {
       private readonly IStatisticsService statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            this.statisticsService = statisticsService;
        }
        
        public IActionResult Index()
        {
            StatisticVM statistics = new StatisticVM();   

            statistics.CountClients=statisticsService.CountClients();
            statistics.CountProducts=statisticsService.CountProducts();
            statistics.CountOrders=statisticsService.CountOrders();
            statistics.SumOrders=statisticsService.SumOrders();

            return View(statistics);
        }
    }
}
