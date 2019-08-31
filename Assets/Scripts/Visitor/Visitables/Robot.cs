namespace Patterns.Visitor.Visitables
{
	public sealed class Robot : IRobotPart
	{
		private IRobotPart[] _robotParts;

		public Robot()
		{
			_robotParts = new IRobotPart[]
			{
				new MechanicalArm(),
				new ThermalImager(),
				new Battery()
			};
		}

		public void Accept(IRobotPartVisitor robotPartVisitor)
		{
			for (int i = 0; i < _robotParts.Length; i++)
			{
				_robotParts[i].Accept(robotPartVisitor);
			}

			robotPartVisitor.Visit(this);
		}
	}
}
