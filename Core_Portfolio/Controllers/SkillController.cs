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
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.V1 = "Yeteneklerim";
            ViewBag.V2 = "Yetenek Listesi";
            ViewBag.V3 = "";
            ViewBag.V2URL = "/Skill/Index/";

            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.V1 = "Yeni Yetenek Ekleme";
            ViewBag.V2 = "Yetenek Listesi";
            ViewBag.V3 = "Yeni Yetenek Ekleme";
            ViewBag.V2URL = "/Skill/Index/";

            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

    }
}
