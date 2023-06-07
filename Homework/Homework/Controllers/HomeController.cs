using Homework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework.Controllers
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
		[HttpPost]
		public IActionResult FinishGame()
		{
			return View();
		}

		[HttpPost]
		public IActionResult StartGame(string NamePlayerFirst, string NamePlayerSecond)
		{
			GameDataModelStatic.NameUserFirst = new PlayerDataModel();
			GameDataModelStatic.NameUserFirst.Name = NamePlayerFirst;
			GameDataModelStatic.NameUserSecond = new PlayerDataModel();
			GameDataModelStatic.NameUserSecond.Name = NamePlayerSecond;
			GameDataModelStatic.FillTheField();
			return View("Game");
		}

		[HttpPost]
		public IActionResult Game(int idPole)
		{
			GameDataModelStatic.Hod(idPole);
			return View();
		}

		[HttpPost]
		public IActionResult RestartGame(int idPole = -1)
		{
			GameDataModelStatic.FillTheField();
			GameDataModelStatic.isX = true;
			return View("Game");
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