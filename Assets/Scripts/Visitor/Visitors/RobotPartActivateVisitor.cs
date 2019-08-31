using Patterns.Visitor.Visitables;
using UnityEngine;

namespace Patterns.Visitor.Visitors
{
	public class RobotPartActivateVisitor : IRobotPartVisitor
	{
		public void Visit(Robot robot)
		{
			Debug.Log("Robot waking up.");
		}

		public void Visit(Battery battery)
		{
			Debug.Log("Battery is charged up.");
		}

		public void Visit(MechanicalArm arm)
		{
			Debug.Log("the mechanical arm is activated.");
		}

		public void Visit(ThermalImager thermalImager)
		{
			Debug.Log("the thermal imager is turned on.");
		}
	}
}
