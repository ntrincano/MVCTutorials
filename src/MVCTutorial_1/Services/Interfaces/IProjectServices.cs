using MVCTutorial_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTutorial_1.Services.Interfaces
{
    public interface IProjectServices
    {
        ProjectEntity GetProjectById(int id);
        IEnumerable<ProjectEntity> GetProjects();
    }
}
