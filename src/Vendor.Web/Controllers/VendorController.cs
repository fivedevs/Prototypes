using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Vendor.Contract;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Vendor.Web.Controllers
{
    [Route("api/[controller]")]
    public class VendorController : Controller
    {
        [HttpGet]
        // GET: /<controller>/
        public IEnumerable<Vendor.Contract.Vendor> Index()
        {
            VendorContext context = new VendorContext();
            return context.GetAsync().Result;
        }
    }
}
