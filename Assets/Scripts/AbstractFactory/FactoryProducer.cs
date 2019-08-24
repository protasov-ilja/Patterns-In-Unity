using Patterns.AbstractFactory.Enums;
using Patterns.AbstractFactory.Factories;
using UnityEngine;

namespace Patterns.AbstractFactory
{
	public sealed class FactoryProducer : MonoBehaviour
	{
		public static AbstractFactory GetFactory(FactoryType factoryType)
		{
			switch(factoryType)
			{
				case FactoryType.Human:
					var humanFactory = new HumanFactory();

					return humanFactory;
				case FactoryType.Animal:
					var animalFactory = new AnimalFactory();

					return animalFactory;
			}

			return null;
		}

	}
}
