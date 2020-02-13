namespace Exa.DataProcess.Domain.AuditData
{
	public class PetaAnswer : ProductAnswer
	{
		 public PetaResults PetaResult { get; set; }
	}

	public enum PetaResults
	{
        NoStock = 0,

        CriticalStock = 1,

        EnoughStock = 2,

        OffToOrder = 3,

        Exempt = 4
    }
}