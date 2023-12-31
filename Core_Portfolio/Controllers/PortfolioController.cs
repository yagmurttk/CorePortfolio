using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.V1 = "Projelerim";
            ViewBag.V2 = "Proje Listesi";
            ViewBag.V3 = "";
            ViewBag.V2URL = "/Portfolio/Index/";

            var values = portfolioManager.TGetList();
            return View(values);
        }
    }
}