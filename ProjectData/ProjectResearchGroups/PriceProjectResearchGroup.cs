using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData.ProjectResearchGroups
{
    public class PriceProjectResearchGroup : ProductBasedProjectResearchGroup<PriceProjectResearchGroupProduct>
    {
        public override ResearchGroupType ResearchGroupType => ResearchGroupType.Price;
    }
}