using Patterns.Strategy.SeekBehaviours;

namespace Patterns.Strategy.Missiles
{
	public sealed class Tomahawk : Missile
	{
		private void Awake()
		{
			seekBehavior = new SeekWithGPS();
		}
	}
}
