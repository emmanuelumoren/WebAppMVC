using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult TempCheck(float temp)
        {
            
          if (temp != 0)
            {
                ViewBag.Msg = Models.FeverTemp.TestForFever(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Pls enter your temperaure and then hit Submit";
                return View();
            }
        }
        [HttpGet]
        public IActionResult TempFever()
        {
            return View();
        }

    }
}

/*
Create new Controller named Doctor to the existing MVC-project and inside it make a View that 
takes a temperature in number form, checks how high it is, and tells you whether you have a 
fever or not. 
Required Features: 
• A form that takes a single numeric value (float or integer) and sends it on to a controller 
action. 
• The value should be interpreted as a temperature, and checked against the thresholds 
for fever. 
• A message should appear on the page, showing whether you have a fever or not. 
Optional:  
• Add a check for hypothermia as well as fever, and display that as a message if you have a too low 
temperature.  
• Add radio buttons to allow switching between Fahrenheit and Celsius degrees. 
Code Requirements:  
• The view must have a form that sends the value into the action. 
• If the value is not set, the page should not get a message to display, otherwise it should 
evaluate it and send back the message. 
• A custom route must be defined for this view. 
• The view must be from an Action inside Doctor controller. 
• The code checking the temperature and giving the diagnose text back must be in a utility 
class with a static method, contained in Models folder. 
• Define a custom route to reach the fever check “/FeverCheck”, rather than having to 
specify a controller and action 
 */