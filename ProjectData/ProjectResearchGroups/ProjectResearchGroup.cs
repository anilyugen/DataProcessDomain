using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData.ProjectResearchGroups
{
    public abstract class ProjectResearchGroup
    {
        public int Id { get; set; }

        public bool HasScore { get; set; }

        public bool IsIncludedInPosScore { get; set; }

        public int ResearchGroupId { get; set; }

        public abstract ResearchGroupType ResearchGroupType { get; }

        public decimal? MaxPoint { get; set; }
    }
}