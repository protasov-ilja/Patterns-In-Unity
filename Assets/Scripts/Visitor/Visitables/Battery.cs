using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor.Visitables
{
	public sealed class Battery : IRobotPart
	{
		public void Accept(IRobotPartVisitor robotPartVisitor)
		{
			robotPartVisitor.Visit(this);
		}
	}
}
