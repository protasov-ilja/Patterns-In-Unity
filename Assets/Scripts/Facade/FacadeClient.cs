using UnityEngine;

namespace Patterns.Facade
{
	public sealed class FacadeClient : MonoBehaviour
	{
		private Player _player;

		private void Start()
		{
			_player = new Player();
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.S))
			{
				// Save the current player instance.
				SaveManager.Instance.SaveGame(_player);
			}
		}
	}
}
