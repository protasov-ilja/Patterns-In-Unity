namespace Patterns.Command.Commands
{
	public sealed class KillSwitchCommand : Command
	{
		private static RemoteControlDevice _receiver;

		private RemoteControlDevice[] _devices;

		public KillSwitchCommand(RemoteControlDevice[] devices)
			: base(_receiver)
		{
			_devices = devices;
		}

		public override void Execute()
		{
			foreach (var device in _devices)
			{
				device.TurnOff();
			}
		}
	}
}
