using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Receive the "amount" value as input from query string. For example, the url is "localhost:1234/home/index?amount=60743".

//Based on the given "amount" value, generate the highest currency denominations.

//Consider, you have denominations of 1000, 500, 100, 50, 10, 5, and 1.

//For example, if the input is "60743", output should be:

//1000 X 60 = 60000

//500 X 1 = 500

//100 X 2 = 200

//10 X 4 = 40

//1 X 3 = 3
namespace Assignment_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult getDenomination(long amount)
        {
            ViewBag.Amount = amount;

            return View();
        }

    }
}