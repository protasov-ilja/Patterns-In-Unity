using Patterns.Visitor.Visitables;
using UnityEngine;

namespace Patterns.Visitor.Visitors
{
	public class RobotPartShutdownVisitor : IRobotPartVisitor
	{
		public void Visit(Robot robot)
		{
			Debug.Log("Robot is going back to sleep.");
		}

		public void Visit(Battery battery)
		{
			Debug.Log("Battery is chargin down.");
		}

		public void Visit(MechanicalArm arm)
		{
			Debug.Log("The mechanical arm is folding back to it's default position.");
		}

		public void Visit(ThermalImager thermalImager)
		{
			Debug.Log("The termal imager is turned off.");
		}
	}
}
