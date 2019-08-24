using UnityEngine;

namespace Patterns.Factory.NPCs
{
	public class Beggar : INPC
	{
		public void Speak()
		{
			Debug.Log("Do you have some change to spare");
		}
	}
}
