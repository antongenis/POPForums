using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PopForums.Mvc.Controllers
{
    public class HomeController : Controller
    {
		private readonly ILogger _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
	    {
            return View();
        }
	}
}
