namespace Exa.DataProcess.Domain.AuditData
{
    public class TespaAuditItem : AuditItem<TespaAnswer>
    {
        public decimal? ShelfSharePercent { get; set; }

        public decimal? ShelfSharePercent_Competitor { get; set; }

        public decimal? TotalTespaResult { get; set; }

        public decimal? TotalTespaResult_Company { get; set; }

        public decimal? TotalTespaResult_Competitor { get; set; }
    }
}