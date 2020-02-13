using System.Collections.Generic;

namespace Exa.DataProcess.Domain.AuditData
{
	public class Audit
	{
		public int Id { get; set; }

        public int CompanyId { get; set; }

        public int ProjectId { get; set; }

        public int SalesPointId { get; set; }

        public List<AuditItem> AuditItems { get; set; }
    }
}