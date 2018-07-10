using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
            //return "this is the <b>Index</b> Action!";
        }

        //public string Welcome(string name , int numTimes =1 )
        //{
        //    return "Welcome " + name + ",numtimes:" + numTimes.ToString();
        //}

        //public string Welcome(string name, int id = 1)
        //{
        //    return "Welcome " + name + ",numtimes:" + id.ToString();
        //}

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Name = name;
            ViewBag.NumTimes = numTimes;
            return View();
            //return "Welcome " + name + ",numtimes:" + id.ToString();
        }
    }
}