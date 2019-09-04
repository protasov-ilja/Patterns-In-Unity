using UnityEngine;

namespace Patterns.EventBus
{
	public sealed class Rocket : MonoBehaviour
	{
		private bool _isQuitting;
		private bool _isLaunched = false;

		private void OnEnable()
		{
			EventBus.StartListening("Launch", Launch);
		}

		private void OnApplicationQuit()
		{
			_isQuitting = true;
		}

		private void OnDisable()
		{
			if (!_isQuitting)
			{
				EventBus.StopListening("Launch", Launch);
			}
		}

		private void Launch()
		{
			if (!_isLaunched)
			{
				_isLaunched = true;
				Debug.Log("Received a launch event : rocket launching!");
			}
		}
	}
}
