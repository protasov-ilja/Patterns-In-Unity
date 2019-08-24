using Patterns.Factory.Enums;
using UnityEngine;

namespace Patterns.Factory
{
	public class NPCSpawner : MonoBehaviour
	{
		[SerializeField] private NPCFactory _factory;

		private INPC _farmer;
		private INPC _beggar;
		private INPC _shopowner;

		public void SpawnVillagers()
		{
			/**
			 We don't want to specify the class to instiate for each type
			 of villager.
			 Instead, we ask the factory to "manufacture" it for us.
			 **/
			_beggar = _factory.GetNPC(NPCType.Beggar);
			_farmer = _factory.GetNPC(NPCType.Farmer);
			_shopowner = _factory.GetNPC(NPCType.Shopowner);

			_beggar.Speak();
			_farmer.Speak();
			_shopowner.Speak();
		}
	}
}
