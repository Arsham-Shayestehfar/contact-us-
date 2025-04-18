using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication13.Models;
using WebApplication13.DataBase;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Messages ()
        {
            return View (DataBase.DataBase.messages);
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            DataBase.DataBase.messages.Add(message);
            return Redirect("/Home/Messages");
        }

      
    }
}
