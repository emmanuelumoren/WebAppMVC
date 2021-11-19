using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebAppAsa.Models;

namespace WebAppAsa.Controllers
{
    public class GameController : Controller
    {
        [HttpPost]
        public IActionResult GuessGame(int userGuess)
        {
            if (!(string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")) || userGuess <= 0 || userGuess >= 100))
            {
                int storedRnd = (int)HttpContext.Session.GetInt32("intRnd");
                string respons = GameRandom.MatchGuess(Convert.ToInt32(userGuess), storedRnd);
                ViewBag.Msg = respons;
            }
            else
            {
                ViewBag.Msg = "Enter a number between 1 and 100 and Submit";
            }
            return View();
        }

        [HttpGet]
        public IActionResult GuessingGame()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")))
            {
                int getRnd = GameRandom.GetRandom(100);
                HttpContext.Session.SetInt32("intRnd", getRnd);
                ViewBag.Rnd = getRnd;
            }
            else
            {
                ViewBag.Rnd = HttpContext.Session.GetInt32("intRnd");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Reset()
        {
            int getRnd = GameRandom.GetRandom(100);
            HttpContext.Session.SetInt32("intRnd", getRnd);
            ViewBag.Rnd = getRnd;
            return RedirectToAction(nameof(GuessGame));
        }
    }
}
