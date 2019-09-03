using UnityEngine;

namespace Patterns.Adapter
{
	public sealed class OnlinePlayer : ScriptableObject 
	{
		public string GetFirstName(int id)
		{
			// Lookup online database
			return "John"; // return a placeholder name
		}

		public string GetLastName(int id)
		{
			// Lookup online database
			return "Doe"; // Return a placeholder last name. 
		}

		public string GetFullName(int id)
		{
			// Lookup online database and get full name
			return "Doe Jonn";
		}
	}
}
