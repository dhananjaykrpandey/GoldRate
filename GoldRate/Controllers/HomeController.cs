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
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor,DbGoldRateContext dbGoldRateContext)
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

            return View();
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
