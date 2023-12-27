using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Portfolio.ViewComponents.Contact
{
    public class SendMessage: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
