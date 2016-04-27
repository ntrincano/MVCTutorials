using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTutorial_1.Controllers
{
    public class ProjectController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "Salut !";
        }

        public string HelloWorld(string Id)
        {
            return HtmlEncoder.Default.HtmlEncode(string.Format("Salut {0} !", Id));
        }
    }
}
