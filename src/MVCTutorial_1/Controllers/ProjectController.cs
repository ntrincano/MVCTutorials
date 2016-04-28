using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;
using MVCTutorial_1.Services.Interfaces;
using MVCTutorial_1.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTutorial_1.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectServices _projectServices;

        public ProjectEntity CurrentProject { get; set; }

        // GET: /<controller>/
        public string Index()
        {
            return "Salut !";
        }

        public string HelloWorld(string Id)
        {
            return HtmlEncoder.Default.HtmlEncode(string.Format("Salut {0} !", Id));
        }

        public ProjectController(IProjectServices projectServices)
        {
            _projectServices = projectServices;

            CurrentProject = _projectServices.GetProjectById(12);
        }
    }
}
