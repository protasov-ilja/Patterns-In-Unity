using UnityEngine;

namespace Patterns.Factory.NPCs
{
	public class Farmer : INPC
	{
		public void Speak()
		{
			Debug.Log("You reap what you sow!");
		}
	}
}
