using Patterns.Observer.Subject;
using UnityEngine;

namespace Patterns.Observer.Observers
{
	public sealed class WarningLight : MonoBehaviour
	{
		[SerializeField] private Light _light;
		private void OnEnable()
		{
			Timer.OnHalfTime += BlinkLight;
		}

		private void OnDisable()
		{
			Timer.OnHalfTime -= BlinkLight;
		}

		private void BlinkLight()
		{
			_light.color = Color.red;
			Debug.Log("[WARNING LIGHT] : It's half-time, blinking the warning light!");
		}
	}
}
