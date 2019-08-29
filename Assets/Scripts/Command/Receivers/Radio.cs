using UnityEngine;

namespace Patterns.Command.Receivers
{
	public sealed class Radio : RemoteControlDevice
	{
		public override void TurnOff()
		{
			Debug.Log("Radio is turned off.");
		}

		public override void TurnOn()
		{
			Debug.Log("Radio is turned on.");
		}
	}
}
