namespace Exa.DataProcess.Domain.ProjectData
{
	public class Range<T>
	{
		public T RangeStart { get; set; }

		public T RangeEnd { get; set; }

		public decimal? Point { get; set; }
	}
}