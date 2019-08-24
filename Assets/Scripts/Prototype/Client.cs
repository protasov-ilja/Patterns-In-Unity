using UnityEngine;

namespace Patterns.Prototype
{
	public class Client : MonoBehaviour
	{
		[SerializeField] private Drone _drone;
		[SerializeField] private Sniper _sniper;
		[SerializeField] private EnemySpawner _spawner;

		private Enemy _spawn;
		private int _incrementorDrone = 0;
		private int _incrementorSniper = 0;

		public void Update()
		{
			if (Input.GetKeyDown(KeyCode.D))
			{
				_spawn = _spawner.SpawnEnemy(_drone);
				_spawn.name = $"DroneClone_{ ++_incrementorDrone }";
				_spawn.transform.Translate(Vector3.forward * _incrementorDrone * 1.5f);
			}

			if (Input.GetKeyDown(KeyCode.S))
			{
				_spawn = _spawner.SpawnEnemy(_sniper);
				_spawn.name = $"SniperClone_{ ++_incrementorSniper }";
				_spawn.transform.Translate(Vector3.forward * _incrementorSniper * 1.5f);
			}
		}
	}
}
