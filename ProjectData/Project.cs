using Exa.DataProcess.Domain.ProjectData.ProjectResearchGroups;
using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData
{
    public class Project
    {
        public int Id { get; set; }

        public bool HasScore { get; set; }

        public Dictionary<int, ProjectResearchGroup> ProjectResearchGroups { get; set; }
    }
}