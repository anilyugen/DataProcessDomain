namespace Exa.DataProcess.Domain.ProjectData
{
    public class ProjectResearchGroupRange : Range<decimal>
    {
        public int Id { get; set; }

        public int ProjectResearchGroupId { get; set; }
    }
}