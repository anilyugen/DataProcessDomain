using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData
{
    public abstract class ProjectResearchGroupQuestion
    {
        public int Id { get; set; }

        public int ProjectResearchGroupId { get; set; }

        public int QuestionId { get; set; }

        public abstract QuestionType QuestionType { get; }

        public decimal? MaxPoint { get; set; }
    }

    public abstract class ProjectResearchGroupQuestionWithOptions<T> : ProjectResearchGroupQuestion where T : ProjectResearchGroupQuestionOption
    {
        public List<T> Options { get; set; }

        public ProjectResearchGroupQuestionWithOptions()
        {
            this.Options = new List<T>();
        }
    }

    public abstract class ProjectResearchGroupQuestionWithRanges<T> : ProjectResearchGroupQuestion, IHasProjectResearchGroupQuestionRanges<T>
    {
        public List<ProjectResearchGroupQuestionRange<T>> QuestionRanges { get; set; }

        public ProjectResearchGroupQuestionWithRanges()
        {
            this.QuestionRanges = new List<ProjectResearchGroupQuestionRange<T>>();
        }
    }

    public class ProjectResearchGroupYesNoQuestion : ProjectResearchGroupQuestionWithOptions<ProjectResearchGroupYesNoQuestionOption>
    {
        public override QuestionType QuestionType { get => QuestionType.YesNo; }
    }

    public class ProjectResearchGroupSingleSelectionQuestion : ProjectResearchGroupQuestionWithOptions<ProjectResearchGroupSelectionQuestionOption>
    {
        public override QuestionType QuestionType => QuestionType.SingleSelection;
    }

    public class ProjectResearchGroupMultipleSelectionQuestion : ProjectResearchGroupQuestionWithOptions<ProjectResearchGroupSelectionQuestionOption>
    {
        public override QuestionType QuestionType => QuestionType.MultipleSelection;
    }

    public class ProjectResearchGroupIntegerEntryQuestion : ProjectResearchGroupQuestionWithRanges<int>
    {
        public override QuestionType QuestionType => QuestionType.IntegerEntry;
    }

    public class ProjectResearchGroupDecimalEntryQuestion : ProjectResearchGroupQuestionWithRanges<decimal>
    {
        public override QuestionType QuestionType => QuestionType.DecimalEntry;
    }

    public class ProjectResearchGroupTextEntryQuestion : ProjectResearchGroupQuestion
    {
        public override QuestionType QuestionType => QuestionType.TextEntry;
    }

    public class ProjectResearchGroupStockQuestion : ProjectResearchGroupQuestion
    {
        public override QuestionType QuestionType => QuestionType.Stock;
    }
}