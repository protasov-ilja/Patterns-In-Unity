using Patterns.Strategy.SeekBehaviours;

namespace Patterns.Strategy.Missiles
{
	public sealed class SideWinder : Missile
	{
		private void Awake()
		{
			seekBehavior = new SeekWithHeat();
		}
	}
}
