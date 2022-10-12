using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ciomag_Andreea_Lab1.Controllers
{
    public class FirstController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "Wellcome to my first ASP.NET Core App!";
        }
        public string Message()
        {
            return "Hello!";
        }
        public string Weather(int temp, string weather)
        {
            return "Today it is " + temp + " degrees and " + weather + ".";
        }
    }
}

