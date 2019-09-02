using UnityEngine;

namespace Patterns.Facade.SubModules
{
	public sealed class CloudManager
	{
		public void UploadSaveGame(string playerData)
		{
			Debug.Log($"Uploading save data. { playerData }");
		}
	}
}
