using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData
{
    public interface IHasProjectResearchGroupProductRanges
    {
        List<ProjectResearchGroupProductRange> ProductRanges { get; set; }
    }
}
