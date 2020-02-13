using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData.ProjectResearchGroups
{
    public class PetaProjectResearchGroup : ProductBasedProjectResearchGroup<PetaProjectResearchGroupProduct>
    {
        public override ResearchGroupType ResearchGroupType => ResearchGroupType.Peta;

        public RgScoreCalculationMethod? ScoreCalculationMethod { get; set; }
    }

    //public class PetaByPointProjectResearchGroup : PetaProjectResearchGroup
    //{
    //    public List<PetaProjectResearchGroupProduct> Items { get; set; }
    //}

    public class PetaByRangeProjectResearchGroup : PetaProjectResearchGroup, IHasProjectResearchGroupRanges
    {
        public List<ProjectResearchGroupRange> Ranges { get; set; }
    }
}