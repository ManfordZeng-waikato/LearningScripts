using LearningScripts.Models;
using LearningScripts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LearningScripts.Controllers
{
    public class StockController : Controller
    {
        private readonly FinnhubService _finnhubService;
        private readonly IOptions<TradingOptions> _tradingoptions;
        public StockController(FinnhubService finnhubService, IOptions<TradingOptions> tradingOptions)
        {
            _finnhubService = finnhubService;
            _tradingoptions = tradingOptions;
        }
        [Route("/stock")]
        public async Task<IActionResult> Index()
        {
            Dictionary<string, object>? responseDictionary =
            await _finnhubService.GetStockPriceQuote(_tradingoptions.Value.DefaultStockSymbol);

            Stock stock = new Stock()
            {
                StockSymbol = _tradingoptions.Value.DefaultStockSymbol,
                CurrentPrice = Convert.ToDouble(responseDictionary["c"].ToString()),
                HighestPrice = Convert.ToDouble(responseDictionary["h"].ToString()),
                LowestPrice = Convert.ToDouble(responseDictionary["l"].ToString()),
                OpenPrice = Convert.ToDouble(responseDictionary["o"].ToString())
            };
            return View(stock);
        }
    }
}
