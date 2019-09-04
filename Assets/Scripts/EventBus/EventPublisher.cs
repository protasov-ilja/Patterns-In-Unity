using UnityEngine;

namespace Patterns.EventBus
{
	public class EventPublisher : MonoBehaviour
	{
		private const string ShootEventKey = "Shoot";
		private const string LaunchEventKey = "Launch";

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.S))
			{
				EventBus.TriggerEvent(ShootEventKey);
			}

			if (Input.GetKeyDown(KeyCode.L))
			{
				EventBus.TriggerEvent(LaunchEventKey);
			}
		}
	}
}
