using Patterns.Strategy.SeekBehaviours;

namespace Patterns.Strategy.Missiles
{
	public sealed class Torpedo : Missile
	{
		private void Awake()
		{
			seekBehavior = new SeekWithSonar();
		}
	}
}
