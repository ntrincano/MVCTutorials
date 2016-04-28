using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;
using MVCTutorial_1.Services.Interfaces;
using MVCTutorial_1.Models.Mappers;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTutorial_1.Controllers
{
    public class ProjectController : Controller
    {
        #region Fields
        private IProjectServices _projectServices;
        #endregion

        #region Public methods
        // GET: /<controller>/
        public ActionResult Index()
        {
            var entities = _projectServices.GetProjects().ToList();
            var vm = entities.ConvertAll(ProjectMapper.ConvertToViewModel);

            return View(vm);
        }

        public ActionResult Create()
        {
            return View();
        }
        #endregion

        #region Constructors
        public ProjectController(IProjectServices projectServices)
        {
            _projectServices = projectServices;
        } 
        #endregion
    }
}
