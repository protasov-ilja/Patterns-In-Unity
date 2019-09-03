using System;

namespace Patterns.ClassAdapter
{
	public class OnlinePlayerClassAdapter : OnlinePlayerOpened, IOnlinePlayer
	{
		public string GetFullNameFirstLast(int userId)
		{
			return $"{ GetFirstName(userId) } { GetLastName(userId) }";
		}

		public string GetFullNameLastFirst(int userId)
		{
			return GetFullName(userId);
		}
	}
}
