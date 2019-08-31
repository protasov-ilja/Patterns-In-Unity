namespace Patterns.Visitor
{
	public interface IRobotPart
	{
		void Accept(IRobotPartVisitor robotPartVisitor);
	}
}
