using Patterns.Visitor.Visitables;

namespace Patterns.Visitor
{
	public interface IRobotPartVisitor
	{
		void Visit(Robot robot);
		void Visit(Battery battery);
		void Visit(MechanicalArm arm);
		void Visit(ThermalImager thermalImager);
	}
}
