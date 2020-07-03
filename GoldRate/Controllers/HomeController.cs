using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoldRate.Models;
using RestSharp;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Newtonsoft.Json;

namespace GoldRate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHttpContextAccessor _accessor;
        private DbGoldRateContext _DbGoldRateContext;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor, DbGoldRateContext dbGoldRateContext)
        {
            _logger = logger;
            _accessor = accessor;
            _DbGoldRateContext = dbGoldRateContext;
        }

        public IActionResult Index()
        {
            //var remoteIpAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            //if (remoteIpAddress== null || remoteIpAddress== "::1")
            //{
            //    remoteIpAddress = "92.96.174.18";
            //}
            //var client = new RestClient($"https://apility-io-ip-geolocation-v1.p.rapidapi.com/{remoteIpAddress}");
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("x-rapidapi-host", "apility-io-ip-geolocation-v1.p.rapidapi.com");
            //request.AddHeader("x-rapidapi-key", "8ba8473872mshd0dc8b3606c8b51p140a8djsnb64af90ef474");
            //request.AddHeader("accept", "application/json");
            //IRestResponse response = client.Execute(request);





            return View(UaeHome().Result);
        }

        private async Task<mUaeHome> UaeHome()
        {
            mUaeHome _UaeHome = new mUaeHome(); ;

            List<mGoldRate> mGoldRates = new List<mGoldRate>();
            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync("https://localhost:44316/goldrate"))
                {
                    string apiResponse = await response.Result.Content.ReadAsStringAsync();

                    mGoldRates = JsonConvert.DeserializeObject<List<mGoldRate>>(apiResponse);
                }
            }

            if (mGoldRates != null && mGoldRates.Count() > 0)
            {
                
                _UaeHome.GoldPriceOz = mGoldRates[0].GoldPriceEvening > 0 ? mGoldRates[0].GoldPriceEvening : mGoldRates[0].GoldPriceAfternoon > 0 ? mGoldRates[0].GoldPriceAfternoon : mGoldRates[0].GoldPriceMorning;
                _UaeHome.GoldPrice24 = mGoldRates[1].GoldPriceEvening > 0 ? mGoldRates[1].GoldPriceEvening : mGoldRates[1].GoldPriceAfternoon > 0 ? mGoldRates[1].GoldPriceAfternoon : mGoldRates[1].GoldPriceMorning;
                _UaeHome.GoldPrice22 = mGoldRates[2].GoldPriceEvening > 0 ? mGoldRates[2].GoldPriceEvening : mGoldRates[2].GoldPriceAfternoon > 0 ? mGoldRates[2].GoldPriceAfternoon : mGoldRates[2].GoldPriceMorning;
                _UaeHome.GoldPrice21 = mGoldRates[3].GoldPriceEvening > 0 ? mGoldRates[3].GoldPriceEvening : mGoldRates[3].GoldPriceAfternoon > 0 ? mGoldRates[3].GoldPriceAfternoon : mGoldRates[3].GoldPriceMorning;
                _UaeHome.GoldPrice18 = mGoldRates[4].GoldPriceEvening > 0 ? mGoldRates[4].GoldPriceEvening : mGoldRates[4].GoldPriceAfternoon > 0 ? mGoldRates[4].GoldPriceAfternoon : mGoldRates[4].GoldPriceMorning;
                //_UaeHome.GoldPriceUpdate =mGoldRates[0].GoldPriceEvening > 0 ?  new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,18,30,0) : mGoldRates[].GoldPriceAfternoon > 0 ? new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 30, 0) : new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 30, 0);
            }





            return _UaeHome;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
