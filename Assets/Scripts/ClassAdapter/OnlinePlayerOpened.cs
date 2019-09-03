using UnityEngine;

namespace Patterns.ClassAdapter
{
	public class OnlinePlayerOpened : ScriptableObject
	{
		public string GetFirstName(int playerId)
		{
			// Lookup online database.
			return "John"; // Retun a placeholder name.
		}

		public string GetLastName(int playerId)
		{       
			// Lookup online database.
			return "Doe"; // Return a placeholder last name.   
		}

		public string GetFullName(int playerId)
		{
			// Lookup online database and pull the full name in this sequence [Last Name & First Name].
			return "Doe Jonn";
		} 
	}
}
