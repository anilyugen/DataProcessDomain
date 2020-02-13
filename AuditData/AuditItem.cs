using Exa.DataProcess.Domain.ProjectData;
using Exa.DataProcess.Domain.ProjectData.ProjectResearchGroups;
using System.Collections.Generic;

namespace Exa.DataProcess.Domain.AuditData
{
    public class AuditItem
    {
        public int Id { get; set; }

        public int AuditId { get; set; }
        
        public bool IsSkipped { get; set; }

        public bool IsValidForSalesPoint { get; set; }

        public int ResearchGroupId { get; set; }

        public ResearchGroupType ResearchGroupType { get; set; }

        public decimal? ImpactPercent { get; set; }

        public decimal? MaxPoint { get; set; }

        public decimal? Point { get; set; }

        public decimal? ImpactedPoint { get; set; }

        public decimal? Score_Impacted { get; set; }

        public decimal? Score_Unimpacted { get; set; }

        public ProjectResearchGroup ProjectResearchGroup { get; set; }
    }

    public class AuditItem<T> : AuditItem where T : Answer
    {
        public List<T> Answers { get; set; }
    }


    

    


    public class AuditItem1
	{



		public int? YesCount { get; set; }

		public int? NoCount { get; set; }

		public int YesNoCount { get; set; }

		public int? YesPercent { get; set; }

		public decimal? NoPercent { get; set; }


	}
}