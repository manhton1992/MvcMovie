using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;   
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        /*
         *  use for View Template Hello World Index.cshtml
         */
        public ActionResult Index()
        {
            return View();
        } 
        
        public ActionResult Welcome(string name, int numTimes =1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
        /*
         * this code use only when you try to work with Controller direct 
         */
        public string Welcome1(string name, int ID = 1)
        {
            
            return HttpUtility.HtmlEncode("Hello " + name + ", ID : " + ID);
        }

        public string Index1()   
        {
            return "this is my <b>default</b> action...";
        }
        
        
    }
}