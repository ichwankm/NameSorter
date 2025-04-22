using Name_Sorter_Refactor.Helper;
using Name_Sorter_Refactor.Interfaces;

namespace Name_Sorter_Refactor.Services
{
	public class CommandHandler : ICommandHandler
	{
		private readonly INameSorter _sorter;
		private readonly IFileService _fileService;

		public CommandHandler(INameSorter sorter, IFileService fileService)
		{
			_sorter = sorter;
			_fileService = fileService;
		}

		public bool Handle(string command)
		{
			const string validCommand = "name-sorter ./unsorted-names-list.txt";

			if (command == validCommand)
			{
				var inputFilePath = PathHelper.GetFilePath("Files/unsorted-names-list.txt");
				var outputFilePath = PathHelper.GetFilePath("Files/sorted-names-list.txt");

				var input = _fileService.Read(inputFilePath);
				var sorted = _sorter.Sort(input);
				foreach (var name in sorted)
					Console.WriteLine(name);

				_fileService.Write(outputFilePath, sorted);
				Console.WriteLine("\nPress Enter to exit.");
				return false;
			}

			Console.WriteLine("\nInvalid command. Please enter 'name-sorter ./unsorted-names-list.txt'\n");
			return true;
		}
	}
}
