namespace Name_Sorter_Refactor.Interfaces
{
	public interface IFileService
	{
		IEnumerable<string> Read(string path);
		void Write(string path, IEnumerable<string> names);
	}
}
