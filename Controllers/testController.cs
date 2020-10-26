using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class testController : Controller
    {
        public void FirstAction() 
        {
            string a = Request.Query["name"];
           
            string b = Request.Form["name"];
            string c = Request.Headers["name"];
            string d = Request.Cookies["name"];
            HttpContext.Session.SetString("name","test");
            HttpContext.Session.GetString("name");

            TestModel entity = new TestModel();
            entity.Name = "abc";
            string Name = entity.Name;


        }
    }
}
