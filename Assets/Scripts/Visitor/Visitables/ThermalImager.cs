
namespace Patterns.Visitor.Visitables
{
	public sealed class ThermalImager : IRobotPart
	{
		public void Accept(IRobotPartVisitor robotPartVisitor)
		{
			robotPartVisitor.Visit(this);
		}
	}
}
