using UnityEngine;

namespace Patterns.Prototype
{
	public class EnemySpawner : MonoBehaviour
	{
		public ICopyable Copy { get; private set; }

		public Enemy SpawnEnemy(Enemy prototype)
		{
			Copy = prototype.Copy();

			return (Enemy)Copy;
		}
	}
}
