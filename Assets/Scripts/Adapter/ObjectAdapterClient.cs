using UnityEngine;

namespace Patterns.Adapter
{
	public sealed class ObjectAdapterClient : MonoBehaviour
	{
		private OnlinePlayer _onlinePlayer;
		private OnlinePlayerObjectAdapter _onlinePlayerAdapter;

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.O))
			{
				_onlinePlayer = ScriptableObject.CreateInstance<OnlinePlayer>();
				_onlinePlayerAdapter = ScriptableObject.CreateInstance<OnlinePlayerObjectAdapter>();

				var firstName = _onlinePlayer.GetFirstName(79);
				var lastName = _onlinePlayer.GetLastName(79);
				var fullNameLastFirst = _onlinePlayer.GetFullName(79);
				var fullNameFirstLast = _onlinePlayerAdapter.GetFullName(_onlinePlayer, 79);

				Debug.Log($"firstName { firstName }");
				Debug.Log($"lastName { lastName }");
				Debug.Log($"fullNameFirstLast { fullNameFirstLast }");
				Debug.Log($"fullNameLastFirst { fullNameLastFirst }");
			}
		}
	}
}
