using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models = ShoppingCart.WebSite.Models;

namespace ShoppingCart.WebSite.Areas.Customer.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/Customer/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(IEnumerable<Models.Customer> model)
        {
            return View("");
        }

    }
}
