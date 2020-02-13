namespace Exa.DataProcess.Domain.ProjectData
{
    public abstract class ProjectResearchGroupQuestionOption
    {
        public int Id { get; set; }

        public int ProjectResearchGroupQuestionId { get; set; }

        public decimal? Point { get; set; }
    }

    public class ProjectResearchGroupYesNoQuestionOption : ProjectResearchGroupQuestionOption
    {
        public YesNoChoice? YesNo { get; set; }
    }

    public class ProjectResearchGroupSelectionQuestionOption : ProjectResearchGroupQuestionOption
    {
        public int QuestionOptionId { get; set; }
    }
}