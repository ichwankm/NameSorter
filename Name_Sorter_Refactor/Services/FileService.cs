using Name_Sorter_Refactor.Interfaces;

namespace Name_Sorter_Refactor.Services
{
	public class FileService : IFileService
	{
		public IEnumerable<string> Read(string path) => File.ReadAllLines(path);
		public void Write(string path, IEnumerable<string> names) => File.WriteAllLines(path, names);
	}
}
