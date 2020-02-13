using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData.ProjectResearchGroups
{
    public class YesNoScoreCardProjectResearchGroup : QuestionBasedProjectResearchGroup
    {
        public override ResearchGroupType ResearchGroupType => ResearchGroupType.YesNoScoreCard;
    }

    public class YesNoScoreCardByRangeProjectResearchGroup : YesNoScoreCardProjectResearchGroup, IHasProjectResearchGroupRanges
    {
        public List<ProjectResearchGroupRange> Ranges { get; set; }
    }
}