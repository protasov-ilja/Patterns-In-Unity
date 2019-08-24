using UnityEngine;

namespace Patterns.AbstractFactory.Factories.Animals
{
	public sealed class Cat : IAnimal
	{
		public void Voice()
		{
			Debug.Log("Cat: Meow!");
		}
	}
}
