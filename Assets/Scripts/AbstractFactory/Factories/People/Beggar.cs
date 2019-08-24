using UnityEngine;

namespace Patterns.AbstractFactory.Factories.People
{
	public sealed class Beggar : IHuman
	{
		public void Speak()
		{
			Debug.Log("Beggar: Do you have some change to spare?");
		}
	}
}
