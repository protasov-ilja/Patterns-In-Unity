using UnityEngine;

namespace Patterns.ObjectPool.Zombies
{
	public class Walker : MonoBehaviour
	{
		public void Walk()
		{
			Debug.Log("Zombie walk!");
		}

		private void OnEnable()
		{
			Walk();
		}
	}
}
