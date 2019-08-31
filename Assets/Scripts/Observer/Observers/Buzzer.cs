using Patterns.Observer.Subject;
using UnityEngine;

namespace Patterns.Observer.Observers
{
	public sealed class Buzzer : MonoBehaviour
	{
		private void OnEnable()
		{
			Timer.OnTimerStarted += PlayStartBuzzer;
			Timer.OnTimerEnded += PlayEndBuzzer;
		}

		private void OnDisable()
		{
			Timer.OnTimerStarted -= PlayStartBuzzer;
			Timer.OnTimerEnded -= PlayEndBuzzer;
		}

		private void PlayStartBuzzer()
		{
			Debug.Log("[BUZZER] : Play start buzzer!");
		}

		private void PlayEndBuzzer()
		{
			Debug.Log("[BUZZER] : Play end buzzer!");
		}
	}
}
