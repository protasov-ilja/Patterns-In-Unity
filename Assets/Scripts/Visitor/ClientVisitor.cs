using Patterns.Visitor.Visitables;
using Patterns.Visitor.Visitors;
using UnityEngine;

namespace Patterns.Visitor
{
	public sealed class ClientVisitor : MonoBehaviour
	{
		private void Update()
		{
			// Active robot
			if (Input.GetKeyDown(KeyCode.O))
			{
				IRobotPart robot = new Robot();
				robot.Accept(new RobotPartActivateVisitor());
			}

			// Shutdown robot
			if (Input.GetKeyDown(KeyCode.S))
			{
				IRobotPart robot = new Robot();
				robot.Accept(new RobotPartShutdownVisitor());
			}
		}
	}
}
