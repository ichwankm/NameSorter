namespace Name_Sorter_Refactor.Interfaces
{
	public interface INameSorter
	{
		IEnumerable<string> Sort(IEnumerable<string> names);
	}
}
