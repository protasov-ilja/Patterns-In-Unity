
namespace Patterns.Visitor.Visitables
{
	public sealed class MechanicalArm : IRobotPart
	{
		public void Accept(IRobotPartVisitor robotPartVisitor)
		{
			robotPartVisitor.Visit(this);
		}
	}
}
