namespace Patterns.State
{
	public sealed class DisabledShipState : IShipState
	{
		public void Execute(Ship ship)
		{
			ship.LogStatus("DISABLED: crew jumping ship.");
		}
	}
}
