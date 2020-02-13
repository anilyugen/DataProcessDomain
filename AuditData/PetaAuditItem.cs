using System;
using System.Collections.Generic;
using System.Text;

namespace Exa.DataProcess.Domain.AuditData
{
    public class PetaAuditItem : AuditItem<PetaAnswer>
    {
        public decimal? AvailabilityPercent { get; set; }

        public int? ExistentMainSkuCount_Company { get; set; }

        public int? TotalMainSkuCount_Company { get; set; }

        public int? ExistentTopSkuCount_Company { get; set; }

        public int? TotalTopSkuCount_Company { get; set; }

        public int? TotalSkuCount { get; set; }

        public int? ExistentMainSkuCount_Company_ForExempt { get; set; }

        public int? ExistentTopSkuCount_Company_ForExempt { get; set; }

        public decimal? AvailabilityPercent_ForExempt { get; set; }

        public int? ExemptCount { get; set; }

        public decimal? ExemptPercent { get; set; }

        public int? TotalMainSkuCount { get; set; }

        public int? TotalTopSkuCount { get; set; }
    }
}