using MVCTutorial_1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCTutorial_1.Models;

namespace MVCTutorial_1.Services
{
    public class ProjectServices : IProjectServices
    {
        public ProjectEntity GetProjectById(int id)
        {
            return new ProjectEntity() { Id = id};
        }
    }
}
