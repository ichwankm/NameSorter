using Name_Sorter_Refactor.Interfaces;

namespace Name_Sorter_UnitTest.Services
{
	public class FakeFileService : IFileService
	{
		public IEnumerable<string> Read(string path) =>
			new List<string> {
			"Orson Milka Iddins",
			"Erna Dorey Battelle",
			"Flori Chaunce Franzel"
			};

		public void Write(string path, IEnumerable<string> names)
		{
			// Just fake - do nothing
		}
	}
}
