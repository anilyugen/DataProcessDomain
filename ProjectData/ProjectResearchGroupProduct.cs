using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData
{
    public abstract class ProjectResearchGroupProduct
    {
        public int Id { get; set; }

        public int ProjectResearchGroupId { get; set; }

        public ProductItem ProductItem { get; set; }

        public bool IsMainSku { get; set; }

        public bool IsTopSku { get; set; }
    }

    public class PetaProjectResearchGroupProduct : ProjectResearchGroupProduct
    {
        public decimal? PetaPoint { get; set; }
    }

    public class TespaProjectResearchGroupProduct : ProjectResearchGroupProduct, IHasProjectResearchGroupProductRanges
    {
        public TespaTarget Target { get; set; }

        public List<ProjectResearchGroupProductRange> ProductRanges { get; set; }
    }

    public class PriceProjectResearchGroupProduct : ProjectResearchGroupProduct
    {
        public decimal? PriceTargetLowerLimit { get; set; }

        public decimal? PriceTargetUpperLimit { get; set; }

        public decimal? PricePoint { get; set; }
    }
}