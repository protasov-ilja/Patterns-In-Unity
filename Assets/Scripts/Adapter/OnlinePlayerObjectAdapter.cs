using UnityEngine;

namespace Patterns.Adapter
{
	public class OnlinePlayerObjectAdapter : ScriptableObject
	{
		public string GetFullName(OnlinePlayer onlinePlayer, int userId)
		{
			return $"{ onlinePlayer.GetFirstName(userId) } { onlinePlayer.GetLastName(userId) }";
		}
	}
}
