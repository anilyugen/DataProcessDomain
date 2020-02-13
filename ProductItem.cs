using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exa.DataProcess.Domain
{
    public class ProductItem
    {
        public string Id
        {
            get
            {
                return
                this.ProductId.HasValue ? "P" + this.ProductId.ToString() :
                this.BrandId.HasValue ? "B" + this.BrandId.ToString() :
                this.CompetitorProductId.HasValue ? "CP" + this.CompetitorProductId.ToString() :
                "CB" + this.CompetitorBrandId.ToString();
            }
        }

        public int? ProductId { get; set; }

        public int? BrandId { get; set; }

        public int? CompetitorProductId { get; set; }

        public int? CompetitorBrandId { get; set; }

        public string ItemName { get; set; }

        public bool IsCompetitor => this.CompetitorProductId.HasValue || this.CompetitorBrandId.HasValue;
    }
}