namespace Exa.DataProcess.Domain.AuditData
{
	public abstract class ProductAnswer : Answer
	{
		public ProductItem ProductItem { get; set; }

        public ProjectData.ProjectResearchGroupProduct ProjectResearchGroupProduct { get; set; }
    }
}