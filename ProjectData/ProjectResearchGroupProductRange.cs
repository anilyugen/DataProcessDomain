namespace Exa.DataProcess.Domain.ProjectData
{
	public class ProjectResearchGroupProductRange : Range<decimal>
	{
		public int Id { get; set; }

		public int ProjectResearchGroupProductId { get; set; }

		public ProductItem ProductItem { get; set; }
	}
}