using Patterns.AbstractFactory.Enums;
using Patterns.AbstractFactory.Factories.Animals;
using Patterns.AbstractFactory.Factories.People;

namespace Patterns.AbstractFactory
{
	public abstract class AbstractFactory
	{
		public abstract IHuman GetHuman(HumanType humanType);
		public abstract IAnimal GetAnimal(AnimalType animalType);
	}
}
