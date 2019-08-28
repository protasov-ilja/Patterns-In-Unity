using UnityEngine;

namespace Patterns.Singleton
{
	public sealed class InventoryManager : Singleton<InventoryManager>
	{
		public void AddItem(int itemID)
		{
			Debug.Log("Adding item to the inventory.");
		}

		public void RemoveItem(int itemID)
		{
			Debug.Log("Removing item to the inventory.");
		}
	}
}
