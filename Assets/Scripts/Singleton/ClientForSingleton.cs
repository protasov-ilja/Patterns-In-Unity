using UnityEngine;

namespace Patterns.Singleton
{
	public class ClientForSingleton : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.I))
			{
				GameManager.Instance.InitializeGame();
			}

			if (Input.GetKeyDown(KeyCode.A))
			{
				InventoryManager.Instance.AddItem(001);
			}

			if (Input.GetKeyDown(KeyCode.R))
			{
				InventoryManager.Instance.RemoveItem(023);
			}
		}
	}
}
