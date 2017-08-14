using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProducts.AdminSite.Controllers
{
    public class CategoryController : Controller
    {
        // GET: /Category 
        public string Index()
        {
            return "Default Category View";
        }

        public string Test(string firstName, string lastName)
        {
            return HttpUtility.HtmlEncode(string.Format("firstName: {0}, lastName: {1}", firstName,lastName));
        }
    }
}