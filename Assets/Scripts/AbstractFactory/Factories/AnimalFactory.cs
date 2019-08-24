using Patterns.AbstractFactory.Enums;
using Patterns.AbstractFactory.Factories.Animals;
using Patterns.AbstractFactory.Factories.People;

namespace Patterns.AbstractFactory.Factories
{
	public sealed class AnimalFactory : AbstractFactory
	{
		public override IAnimal GetAnimal(AnimalType animalType)
		{
			switch(animalType)
			{
				case AnimalType.Cat:
					var cat = new Cat();

					return cat;
				case AnimalType.Dog:
					IAnimal dog = new Dog();

					return dog;
			}

			return null;
		}

		public override IHuman GetHuman(HumanType humanType)
		{
			return null;
		}
	}
}
