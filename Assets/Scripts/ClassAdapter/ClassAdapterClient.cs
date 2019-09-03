using UnityEngine;

namespace Patterns.ClassAdapter
{
	public sealed class ClassAdapterClient : MonoBehaviour
	{
		private IOnlinePlayer _onlinePlayer;

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.C))
			{
				_onlinePlayer = ScriptableObject.CreateInstance<OnlinePlayerClassAdapter>();
				var firstName = _onlinePlayer.GetFirstName(79);
				var lastName = _onlinePlayer.GetLastName(79);
				var fullNameLastFirst = _onlinePlayer.GetFullNameLastFirst(79);
				var fullNameFirstLast = _onlinePlayer.GetFullNameFirstLast(79);

				Debug.Log($"firstName { firstName }");
				Debug.Log($"lastName { lastName }");
				Debug.Log($"fullNameLastFirst { fullNameLastFirst }");
				Debug.Log($"fullNameFirstLast { fullNameFirstLast }");
			}
		}
	}
}
