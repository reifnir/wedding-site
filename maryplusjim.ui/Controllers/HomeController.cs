using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using maryplusjim.ui.Model;
using maryplusjim.ui.Db;
using Microsoft.Extensions.Options;

namespace maryplusjim.ui.Controllers
{
    public class HomeController : Controller
    {
        DocumentDBRepository<WeddingContent> db;

        public HomeController(IOptions<DbConfig> dbConfig)
        {
            //this.db = new DocumentDBRepository<WeddingContent>(dbConfig.Value);
        }
        public async Task<IActionResult> Index()
        {
            //var content = await Db.DocumentDBRepository<WeddingContent>.GetItemAsync("");
            //WeddingContent content;
            //try { content = await db.GetItemAsync(""); }
            //catch { content = WeddingContent.Default(); }

            return View(WeddingContent.Default());
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
