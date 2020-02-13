namespace Exa.DataProcess.Domain.AuditData
{
	public class TespaAnswer : ProductAnswer
	{
        public decimal TespaResult { get; set; }
		
		public decimal? ShelfSharePercent { get; set; }

        public decimal? ShelfSharePercent_AllProducts { get; set; }
    }
}