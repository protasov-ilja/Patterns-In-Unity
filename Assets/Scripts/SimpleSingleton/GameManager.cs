using UnityEngine;

namespace Patterns.SimpleSingleton
{
	public sealed class GameManager : MonoBehaviour
	{
		public static GameManager Instance { get; set; }

		private void Awake()
		{
			if (Instance == null)
			{
				// Assigning only if there's no other instances in memory.
				Instance = this;
			}
			else if (Instance != null)
			{
				// Destroying itself if detects duplication.
				Destroy(gameObject);
			}
		}

		public void InitializeScene()
		{
			// Load persistent game state variables from the save system.
			// Load game systems and dependencies.
		}
	}
}
