using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exa.DataProcess.Domain.AuditData
{
	public abstract class Answer
	{
		public int Id { get; set; }

		public int AuditItemId { get; set; }

		public int ProjectResearchGroupId { get; set; }

		public decimal? Point { get; set; }
	}
}