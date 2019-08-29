using Patterns.Command.Commands;
using Patterns.Command.Receivers;
using UnityEngine;

namespace Patterns.Command
{
	public sealed class CommandsClient : MonoBehaviour
	{
		private RemoteControlDevice _radioReceiver;
		private RemoteControlDevice _televisionReceiver;
		private RemoteControlDevice[] _devices = new RemoteControlDevice[2];

		private void Start()
		{
			_radioReceiver = new Radio();
			_televisionReceiver = new Television();
			_devices[0] = new Radio();
			_devices[1] = new Television();
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.O))
			{
				var commandTV = new TurnOnCommand(_devices[0]);
				var commandRadio = new TurnOnCommand(_devices[1]);

				var invoker = new Invoker();

				invoker.SetCommand(commandTV);
				invoker.ExecuteCommand();

				invoker.SetCommand(commandRadio);
				invoker.ExecuteCommand();
			}

			if (Input.GetKeyDown(KeyCode.K))
			{
				var commandKill = new KillSwitchCommand(_devices);

				var invoker = new Invoker();

				invoker.SetCommand(commandKill);
				invoker.ExecuteCommand();
			}
		}
	}
}
