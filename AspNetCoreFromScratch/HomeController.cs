using System;
using System.Linq;
using System.Text.Json;
using AspNetCoreFromScratch.State_Mng;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using AspNetCoreFromScratch.State_Mng;
using Microsoft.AspNetCore.Http.Extensions;

namespace AspNetCoreFromScratch
{
    public class HomeController : Controller
    {
        private readonly IOptions<PositionOptions> _positionOptions;
        private readonly TopItemSettings _yearSettings, _monthSettings;
        private readonly IConfiguration _cfg;
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(
            IOptionsSnapshot<PositionOptions> positionOptions, 
            IOptionsSnapshot<TopItemSettings> topItemOptions,
            IConfiguration cfg,
            ILogger<HomeController> logger
            )
        {
            _positionOptions = positionOptions;
            _yearSettings = topItemOptions.Get(TopItemSettings.YEAR);
            _monthSettings = topItemOptions.Get(TopItemSettings.MONTH);
            _logger = logger;
            
            _cfg = cfg;
        }

        public IActionResult Exception()
        {
            throw new Exception("Test Exception Handler");
        }
        
        // GET
        public IActionResult Index()
        {
            OutputEndpointInfo();
            
            try
            {
                PositionOptions positionOptions = _positionOptions.Value;
                //_cfg.GetSection("Position").Get<PositionOptions>();
                
                _logger.LogInformation("Home Index Action Raised");
                
                return View(
                    "HomeIndexView",
                    new HomeIndexViewModel()
                    {
                        Content = $"Home Index<br>Top Item Settings: year - {_yearSettings}, month - {_monthSettings}",
                        Status = $"Speciality: {positionOptions.Title}, Name: {positionOptions.Name}"
                        /*$"Speciality: {_positionOptions.Value.Title}, Name: {_positionOptions.Value.Name}"*/
                    }
                );
            }

            catch (OptionsValidationException ex)
            {
                return View(
                    "HomeIndexView",
                    new HomeIndexViewModel()
                    {
                        Content = "Errors",
                        Status = ex.Message
                    });
            }

        }

        private void OutputEndpointInfo()
        {
            var endpoint = HttpContext.GetEndpoint();

            if (endpoint is RouteEndpoint routeEndpoint)
            {
                Console.WriteLine($"Pattern:{routeEndpoint.RoutePattern.RawText}");
                Console.WriteLine($"Params: {string.Join(", ", routeEndpoint.RoutePattern.Parameters.Select(p => p.Name))}");
            }

            Console.WriteLine("Metadatas:");

            foreach (var metadata in endpoint.Metadata)
                Console.WriteLine($"Metadata: {metadata}");
        }

        public IActionResult SessionStart()
        {
            UserVisitedLinksProfile userProfile = new UserVisitedLinksProfile("User");

            HttpContext.Session.SetUserVisitedLinksProfile(userProfile);
            
            return Content("User Profile Created");
        }

        public IActionResult SessionLink1()
        {
            return AddCurrentVisitedLinkInfo();
        }

        public IActionResult SessionLink2()
        {
            return AddCurrentVisitedLinkInfo();
        }

        public IActionResult SessionLink3()
        {
            return AddCurrentVisitedLinkInfo();
        }

        public IActionResult SessionState()
        {
            UserVisitedLinksProfile userProfile = HttpContext.Session.GetUserVisitedLinksProfile();

            if (userProfile is null)
                return BadRequest("User profile is not created yet");

            return Content(
                JsonSerializer.Serialize(userProfile, typeof(UserVisitedLinksProfile)));
        }
        
        private IActionResult AddCurrentVisitedLinkInfo()
        {
            UserVisitedLinksProfile userProfile = HttpContext.Session.GetUserVisitedLinksProfile();

            if (userProfile is null)
                return BadRequest("User profile is not created yet");

            VisitedLinkInfo visitedLinkInfo =
                new VisitedLinkInfo()
                {
                    Url = HttpContext.Request.GetDisplayUrl(),
                    LastVisitDateTime = DateTime.Now
                };
            
            userProfile.AddOrUpdateVisitedLinkInfo(visitedLinkInfo);

            HttpContext.Session.SetUserVisitedLinksProfile(userProfile);
            
            return Content($"{visitedLinkInfo.Url} visited at {visitedLinkInfo.LastVisitDateTime}");
        }
    }
}