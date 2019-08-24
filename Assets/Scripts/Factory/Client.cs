using UnityEngine;

namespace Patterns.Factory
{
	public class Client : MonoBehaviour
	{
		[SerializeField] private NPCSpawner _spawnerNPC;

		public void Update()
		{
			if (Input.GetKeyDown(KeyCode.S))
			{
				_spawnerNPC.SpawnVillagers();
			}
		}
	}
}
