using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData.ProjectResearchGroups
{
    public abstract class ProductBasedProjectResearchGroup<T> : ProjectResearchGroup where T : ProjectResearchGroupProduct
    {
        public List<T> Items { get; set; }

        public ProductBasedProjectResearchGroup()
        {
            this.Items = new List<T>();
        }
    }
}