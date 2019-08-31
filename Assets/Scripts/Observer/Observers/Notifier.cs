using Patterns.Observer.Subject;
using UnityEngine;

namespace Patterns.Observer.Observers
{
	public sealed class Notifier : MonoBehaviour
	{
		/// <summary>
		/// Adding the object as a observer of the OnTimerEnded event once it //get's enabled
		/// </summary>
		private void OnEnable()
		{
			Timer.OnTimerEnded += ShowGameOverPopUp;
		}

		/// <summary>
		/// In case the object is disabled, removing it as an observer of //OnTimerEnded. 
		/// </summary>
		private void OnDisable()
		{
			Timer.OnTimerEnded -= ShowGameOverPopUp;
		}

		private void ShowGameOverPopUp()
		{
			Debug.Log("[NOTIFIER] : Show game over pop up!");
		}
	}
}
