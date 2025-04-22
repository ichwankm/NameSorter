using Name_Sorter_Refactor.Services;

namespace Name_Sorter_Refactor
{
	public class Program
	{
		static void Main(string[] args)
		{
			var sorter = new LastNameSorter();
			var fileService = new FileService();
			var commandHandler = new CommandHandler(sorter, fileService);

			bool running = true;

			while (running)
			{
				Console.WriteLine("Insert Command:\n");
				var command = Console.ReadLine();
				running = commandHandler.Handle(command);
			}
		}
	}
}
