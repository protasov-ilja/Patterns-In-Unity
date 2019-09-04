using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.EventBus
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
