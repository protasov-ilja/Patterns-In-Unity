using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.EventBus
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
