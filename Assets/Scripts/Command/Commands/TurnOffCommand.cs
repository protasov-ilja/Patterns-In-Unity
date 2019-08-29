namespace Patterns.Command.Commands
{
	public sealed class TurnOffCommand : Command
	{
		public TurnOffCommand(RemoteControlDevice receiver)
			: base(receiver)
		{ }

		public override void Execute()
		{
			receiver.TurnOff();
		}
	}
}
