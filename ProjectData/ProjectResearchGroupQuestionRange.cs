namespace Exa.DataProcess.Domain.ProjectData
{
    public class ProjectResearchGroupQuestionRange<T> : Range<T>
    {
        public int Id { get; set; }

        public int ProjectResearchGroupQuestionId { get; set; }
    }

    public class ProjectResearchGroupQuestionIntegerRange : ProjectResearchGroupQuestionRange<int>
    { }

    public class ProjectResearchGroupQuestionDecimalRange : ProjectResearchGroupQuestionRange<int>
    { }
}