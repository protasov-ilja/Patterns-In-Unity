namespace Patterns.ClassAdapter
{
	public interface IOnlinePlayer
	{
		string GetFirstName(int userId);
		string GetLastName(int userId);
		string GetFullNameLastFirst(int userId);
		string GetFullNameFirstLast(int userId);
	}
}
