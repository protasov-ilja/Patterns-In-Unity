using UnityEngine;

namespace Patterns.ServiceLocator
{
	public class ClientServiceLocator : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.O))
			{
				ServiceLocator.Instance.GetService<LightingCoordinator>().TurnOffLights();
			}

			if (Input.GetKeyDown(KeyCode.C))
			{
				ServiceLocator.Instance.GetService<CurrencyConverter>().ConvertToUsDollar(10);
			}

			if (Input.GetKeyDown(KeyCode.L))
			{
				ServiceLocator.Instance.GetService<LobbyCoordinator>().AddPlayerToLobby();
			}
		}
	}
}
