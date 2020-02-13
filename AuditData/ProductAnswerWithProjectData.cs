using Exa.DataProcess.Domain.ProjectData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exa.DataProcess.Domain.AuditData
{
    public class ProductAnswerWithProjectData
    {
        public ProductAnswer Answer { get; set; }

        public ProjectResearchGroupProduct ProjectData { get; set; }
    }
}
