using UnityEngine;

namespace Patterns.Factory.NPCs
{
	public class Shopowner : INPC
	{
		public void Speak()
		{
			Debug.Log("Do you wish to purchase something?");
		}
	}
}
