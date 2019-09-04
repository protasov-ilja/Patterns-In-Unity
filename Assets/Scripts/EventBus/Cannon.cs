using UnityEngine;

namespace Patterns.EventBus
{
	public class Cannon : MonoBehaviour
	{
		private bool _isQuitting;

		private void OnEnable()
		{
			EventBus.StartListening("Shoot", Shoot);
		}

		private void OnApplicationQuit()
		{
			_isQuitting = true;
		}


		private void OnDisable()
		{
			if (!_isQuitting)
			{
				EventBus.StopListening("Shoot", Shoot);
			}
		}

		private void Shoot()
		{
			Debug.Log("Received a shoot event : shooting cannon!");
		}
	}
}
