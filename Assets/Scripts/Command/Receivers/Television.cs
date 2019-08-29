using UnityEngine;

namespace Patterns.Command.Receivers
{
	public class Television : RemoteControlDevice
	{
		public override void TurnOff()
		{
			Debug.Log("TV turned off.");
		}

		public override void TurnOn()
		{
			Debug.Log("TV turned on.");
		}
	}
}
