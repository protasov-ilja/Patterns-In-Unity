using UnityEngine;

namespace Patterns.State
{
	public sealed class StateClient : MonoBehaviour
	{
		[SerializeField] private Ship _ship;

		private void Update()
		{
			if (Input.GetKeyDown("n"))
			{
				_ship.Normalize();
			}

			if (Input.GetKeyDown("a"))
			{
				_ship.TriggerRedAlert();
			}

			if (Input.GetKeyDown("d"))
			{
				_ship.DisableShip();
			}
		}
	}
}
