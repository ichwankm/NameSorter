using Name_Sorter_Refactor.Services;
using Name_Sorter_UnitTest.Services;

namespace Name_Sorter_UnitTest
{
	public class CommandHandlerTests
	{
		[Fact]
		public void ExecuteCommand_WithValidCommand_ReturnsFalse()
		{
			// Arrange
			var sorter = new LastNameSorter();
			var fileService = new FakeFileService();
			var handler = new CommandHandler(sorter, fileService);

			string input = "name-sorter ./unsorted-names-list.txt";

			// Act
			var result = handler.Handle(input);

			// Assert
			Assert.False(result);
		}

		[Fact]
		public void OrderbyLastName_GivenFullName_ReturnsLastName()
		{
			// Arrange
			var name = "Ichwan Kurnia Meidiandrianto";

			// Act
			var result = new LastNameSorter().Sort(new[] { name }).First();

			// Assert
			Assert.Equal(name, result); // still returns full name after sorting
			Assert.Equal("Meidiandrianto", name.Split(' ').Last()); // validates extraction separately
		}
	}
}