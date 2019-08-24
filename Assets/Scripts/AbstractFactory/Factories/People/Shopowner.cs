using UnityEngine;

namespace Patterns.AbstractFactory.Factories.People
{
	public sealed class Shopowner : IHuman
	{
		public void Speak()
		{
			Debug.Log("Shopowner: Do you wish to purchase something?");
		}
	}
}
