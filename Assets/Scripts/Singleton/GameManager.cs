using UnityEngine;

namespace Patterns.Singleton
{
	// Inheriting Singleton and specifying the type.
	public sealed class GameManager : Singleton<GameManager>
	{
		public void InitializeGame()
		{
			Debug.Log("Initializing the game.");
		}
	}
}
