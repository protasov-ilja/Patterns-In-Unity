using UnityEngine;

namespace Patterns.AbstractFactory.Factories.Animals
{
	public sealed class Dog : IAnimal
	{
		public void Voice()
		{
			Debug.Log("Dog: Woof!");
		}
	}
}
