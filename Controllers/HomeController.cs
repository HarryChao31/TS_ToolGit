using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;
using System.Reflection;
using TS_Tool.DataLayer;
using TS_Tool.Models;


namespace TS_Tool.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public IActionResult Index(string Webid, string Refno)
        {

            ViewBag.WebId = Webid;
            ViewBag.Refno = Refno;
            var sql = $"EXEC GetBetInfoByWebidAndRefno {Webid}, '{Refno}'";
            var betdetailList = _db.BetInformation
                .FromSqlRaw($"EXEC GetBetInfoByWebidAndRefno {Webid}, '{Refno}'")
                .ToList();

            return PartialView("_BetDetailPartialView", betdetailList);
            

        }
        [HttpPost]
        public IActionResult SWError(string Webid, string Refno) {
            ViewBag.WebId = Webid;
            ViewBag.Refno = Refno;
            var SWError = _db.SWErrorInfo
        .FromSqlRaw($"EXEC GetSWErrorByWebidAndRefno {Webid}, '{Refno}'")
        .ToList();
            return PartialView("_SWErrorPartialView", SWError);
        }

        public ActionResult detail(string webIdInput, string refnoInput)
        {

            ViewBag.WebId = webIdInput;
            ViewBag.Refno = refnoInput;

            var betdetail = new Betdetail { };// Webid = 3, Refno = "33333", UserName = "TestHarry", Transid = 33333, Match = "HTeam vs ATeam", League = "League", MatchResultId = 1234567, Status = "Won", OsStatus = "Won", BetType = 1, BetOption = "H", Remark = "", Action ="Deduct", ErrorMessage ="No Error", HostName = "test-wl.com.tw", Request = "{Username = 'TestHarry',Refno = '33333',Amount = 10}" };


            return PartialView("_BetDetailPartialView", betdetail);

            //return View(betdetail);
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
