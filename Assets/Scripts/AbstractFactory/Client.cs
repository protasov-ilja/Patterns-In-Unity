using UnityEngine;

namespace Patterns.AbstractFactory
{
	public class Client : MonoBehaviour
	{
		[SerializeField] private NPCSpawner _spawnerNPC;

		public void Update()
		{
			if (Input.GetKeyDown(KeyCode.U))
			{
				_spawnerNPC.SpawnHumans();
			}

			if (Input.GetKeyDown(KeyCode.A))
			{
				_spawnerNPC.SpawnAnimals();
			}
		}
	}
}
