using UnityEngine;

namespace Patterns.SimpleSingleton
{
	class ClientForSingleton : MonoBehaviour
	{
		void Start()
		{
			GameManager.Instance.InitializeScene();
		}
	}
}
