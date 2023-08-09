using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Single_and_multiple_cheak_boxes.Models;
using System.Diagnostics;


namespace Single_and_multiple_cheak_boxes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    TermsandCondition terms = new TermsandCondition()
        //    {
        //        Ischesked = false
        //    };
        //    return View(terms);
        //}
        //[HttpPost]
        //public IActionResult Index(TermsandCondition data)
        //{
        //    var _data = data.Ischesked;
        //    return View();
        //}

        public IActionResult Index()
        {
            var model = new ViewModel()
            {
                CheckBoxes = new List<CheakBoxOptions>
                {
                    new CheakBoxOptions(){Text="Cricket",Value="Cricket",ISCheaked=false},
                    new CheakBoxOptions(){Text="Football",Value="Football",ISCheaked=false},
                    new CheakBoxOptions(){Text="Tennis",Value="Tennis",ISCheaked=false}
                }
            };
            return View(model);
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