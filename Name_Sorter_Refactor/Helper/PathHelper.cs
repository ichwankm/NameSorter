namespace Name_Sorter_Refactor.Helper
{
	public static class PathHelper
	{
		// Gets the root directory of the project
		public static string GetProjectRoot()
		{
			// Go up 3-4 levels depending on context (adjust if needed)
			return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
		}

		// Gets full path to a file inside the project, e.g., "Files/unsorted-names-list.txt"
		public static string GetFilePath(string relativePath)
		{
			return Path.Combine(GetProjectRoot(), relativePath);
		}
	}
}
