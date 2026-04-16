namespace LINQ.Helpers
{
	public class StringCaseInsensitiveComparer : IComparer<string>
	{
		public int Compare(string? x, string? y)
		{
			//1 x > y
			//0 == 
			//-1
			return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
		}
	}
}
