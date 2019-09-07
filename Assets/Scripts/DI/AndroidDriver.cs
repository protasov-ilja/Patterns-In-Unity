using UnityEngine;

namespace Patterns.DI
{
	public class AndroidDriver : IDriver
	{
		private Bike _bike;

		public void Control(Bike bike)
		{
			_bike = bike;
			Debug.Log("This bike will be controlled by an AI");
		}
	}
}
