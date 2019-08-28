using UnityEngine;

namespace Patterns.Strategy.SeekBehaviours
{
	public sealed class SeekWithSonar : ISeekBehaviour
	{
		public void Seek()
		{
			Debug.Log("Seeking with sonar.");
		}
	}
}
