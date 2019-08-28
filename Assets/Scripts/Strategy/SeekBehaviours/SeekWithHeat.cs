using UnityEngine;

namespace Patterns.Strategy.SeekBehaviours
{
	public sealed class SeekWithHeat : ISeekBehaviour
	{
		public void Seek()
		{
			Debug.Log("Seeking target with heat signature.");
		}
	}
}
