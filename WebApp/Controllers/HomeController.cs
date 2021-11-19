using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAsa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()// Get 
        {
            return View();// print out reslt
        }
        public IActionResult About()//Get
        {
            return View();//print out reslt
        }
        public IActionResult Contact()//post
        {
            return View();//print out reslt
        }
        public IActionResult Portfolio()//Get
        {
            return View();//print out reslt
        }

    }
}
