using UnityEngine;

namespace Patterns.Strategy
{
	public abstract class Missile : ScriptableObject
	{
		protected ISeekBehaviour seekBehavior;

		public void ApplySeek()
		{
			seekBehavior.Seek();
		}

		public void SetSeekBehavior(ISeekBehaviour seekType)
		{
			seekBehavior = seekType;
		}
	}
}
