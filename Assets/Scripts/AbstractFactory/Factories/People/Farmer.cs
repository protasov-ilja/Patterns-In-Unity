using UnityEngine;

namespace Patterns.AbstractFactory.Factories.People
{	
	public class Farmer : IHuman
	{
		public void Speak()
		{
			Debug.Log("Farmer: You reap what you sow!");
		}
	}
}
