using System.Collections.Generic;

namespace Exa.DataProcess.Domain.ProjectData
{
	public interface IHasProjectResearchGroupRanges
	{
		List<ProjectResearchGroupRange> Ranges { get; set; }
	}
}