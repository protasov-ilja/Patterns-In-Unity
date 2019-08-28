using UnityEngine;

namespace Patterns.Strategy.SeekBehaviours
{
	public sealed class SeekWithGPS : ISeekBehaviour
	{
		public void Seek()
		{
			Debug.Log("Seeking target with GPS coordinates");
		}
	}
}
