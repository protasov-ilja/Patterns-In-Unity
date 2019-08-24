using Patterns.AbstractFactory.Enums;
using Patterns.AbstractFactory.Factories.Animals;
using Patterns.AbstractFactory.Factories.People;

namespace Patterns.AbstractFactory.Factories
{
	public sealed class HumanFactory : AbstractFactory
	{
		public override IHuman GetHuman(HumanType humanType)
		{
			switch(humanType)
			{
				case HumanType.Beggar:
					var beggar = new Beggar();

					return beggar;
				case HumanType.Farmer:
					var farmer = new Farmer();

					return farmer;
				case HumanType.Shopowner:
					var shopowner = new Shopowner();

					return shopowner;
			}

			return null;
		}

		public override IAnimal GetAnimal(AnimalType animalType)
		{
			return null;
		}
	}
}
