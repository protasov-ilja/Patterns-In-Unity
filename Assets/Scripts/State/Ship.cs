using UnityEngine;

namespace Patterns.State
{
	public sealed class Ship : MonoBehaviour
	{
		private IShipState _currentState;

		private void Awake()
		{
			_currentState = new NormalShipState();
			_currentState.Execute(this);
		}

		public void Normalize()
		{
			_currentState = new NormalShipState();
			_currentState.Execute(this);
		}

		public void TriggerRedAlert()
		{
			_currentState = new AlertShipState();
			_currentState.Execute(this);
		}

		public void DisableShip()
		{
			_currentState = new DisabledShipState();
			_currentState.Execute(this);
		}

		public void LogStatus(string status)
		{
			Debug.Log(status);
		}
	}
}
