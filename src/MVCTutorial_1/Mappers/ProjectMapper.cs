using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCTutorial_1.ViewModels.Project;

namespace MVCTutorial_1.Models.Mappers
{
    public static class ProjectMapper
    {
        public static ProjectViewModel ConvertToViewModel(ProjectEntity entity)
        {
            return new ProjectViewModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}
