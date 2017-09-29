using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IphoneCSharp.Controllers
{
    public class IphoneController : Controller
    {
		// GET: /<controller>/
		public string Index()
		{
			return "This is my default action...";
		}

		// 
		// GET: /HelloWorld/Welcome/ 

		public IActionResult Welcome(string name, int numTimes = 1)
		{
			ViewData["Message"] = "Hello " + name;
			ViewData["NumTimes"] = numTimes;

			return View();
		} 

    }
}
