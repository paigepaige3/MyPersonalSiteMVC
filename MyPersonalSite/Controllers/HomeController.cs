using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration; //added for acess to info in appsettings.json
using MyPersonalSite.Models;
using MimeKit; //Added for access to MimeMessage class
using MailKit.Net.Smtp; //Added for access to SmtpClient class
//using Microsoft.Data.SqlClient; //added for access to Connected SQL Client
using Microsoft.CodeAnalysis;

namespace MyPersonalSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();//(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Links()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        private readonly IConfiguration _config;

 
        
    }
}