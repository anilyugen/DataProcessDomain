namespace Exa.DataProcess.Domain.AuditData
{
    public class QuestionAnswer : Answer
    {
        public int QuestionId { get; set; }
    }

    public class YesNoQuestionAnswer : QuestionAnswer
    {
        public YesNoChoice YesNo { get; set; }
    }

    public class SelectionQuestionAnswer : QuestionAnswer
    {
        public int QuestionOptionId { get; set; }
    }

    public class NumericValueQuestionAnswer : QuestionAnswer
    {
        public decimal NumericValue { get; set; }
    }

    public class TextValueQuestionAnswer : QuestionAnswer
    {
        public string TextValue { get; set; }
    }
}