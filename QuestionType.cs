namespace Exa.DataProcess.Domain
{
    public enum QuestionType : byte
    {
        SingleSelection = 0,

        MultipleSelection = 1,

        DecimalEntry = 2,

        YesNo = 3,

        IntegerEntry = 4,

        TextEntry = 5,

        Stock = 6,
    }
}