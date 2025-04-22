using Name_Sorter_Refactor.Interfaces;

namespace Name_Sorter_Refactor.Services
{
	public class LastNameSorter : INameSorter
	{
		public IEnumerable<string> Sort(IEnumerable<string> names) =>
			names.OrderBy(name => name.Split(' ').Last());
	}
}
