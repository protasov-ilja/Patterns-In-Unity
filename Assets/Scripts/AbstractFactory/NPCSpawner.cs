using Patterns.AbstractFactory.Enums;
using Patterns.AbstractFactory.Factories.Animals;
using Patterns.AbstractFactory.Factories.People;
using UnityEngine;

namespace Patterns.AbstractFactory
{
	public sealed class NPCSpawner : MonoBehaviour
	{
		private IAnimal _cat;
		private IAnimal _dog;
		private IHuman _farmer;
		private IHuman _beggar;
		private IHuman _shopowner;

		private AbstractFactory _factory;
		public void SpawnAnimals()
		{
			_factory = FactoryProducer.GetFactory(FactoryType.Animal);

			_cat = _factory.GetAnimal(AnimalType.Cat);
			_dog = _factory.GetAnimal(AnimalType.Dog);
			_cat.Voice();
			_dog.Voice();
		}

		public void SpawnHumans()
		{
			_factory = FactoryProducer.GetFactory(FactoryType.Human);

			_beggar = _factory.GetHuman(HumanType.Beggar);
			_farmer = _factory.GetHuman(HumanType.Farmer);
			_shopowner = _factory.GetHuman(HumanType.Shopowner);

			_beggar.Speak();
			_farmer.Speak();
			_shopowner.Speak();
		}
	}
}
