using UnityEngine;

namespace Patterns.DI
{
	public class HumanDriver : IDriver
	{
		private Bike _bike;

		public void Control(Bike bike)
		{
			_bike = bike;
			Debug.Log("A human (player) will control the bike");
		}
	}
}
