namespace Patterns.Command.Commands
{
	public sealed class TurnOnCommand : Command
	{
		public TurnOnCommand(RemoteControlDevice receiver)
			: base(receiver)
		{ }

		public override void Execute()
		{
			receiver.TurnOn();
		}
	}
}
