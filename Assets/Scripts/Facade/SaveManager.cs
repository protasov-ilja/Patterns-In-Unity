using Patterns.Singleton;
using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using Patterns.Facade.SubModules;

namespace Patterns.Facade
{
	public class SaveManager : Singleton<SaveManager>
	{
		private const string PlayerInfoFileName = "playerInfo.dat";

		private UIManager _uIManger;
		private PlayerData _playerData;
		private ScoreManager _scoreManager;
		private CloudManager _cloudManager;

		public void SaveGame(Player player)
		{
			// 1 - Show the save icon on hte corner of the sceen
			_uIManger = new UIManager();
			_uIManger.DisplaySaveIcon();

			// 2 - Initializing a new Player Data
			_playerData = new PlayerData();
			_playerData.health = player.GetHealth();
			_playerData.playerId = player.GetPlayerId();

			// 3 - Getting the player's high score.
			_scoreManager = new ScoreManager();
			_playerData.score = _scoreManager.GetScore(player.GetPlayerId());

			// 4 - Let's serialize the player data.
			SerializePlayerData(_playerData, true);
		}

		private void SerializePlayerData(PlayerData playerData, bool isCloudSave)
		{
			// Serializing the PlayerData instance
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream file = File.Create($"{ Application.persistentDataPath }/{ PlayerInfoFileName }");
			formatter.Serialize(file, playerData);
			file.Close();

			// Uploading the serialized playerInfo.dat file
			if (isCloudSave)
			{
				_cloudManager = new CloudManager();
				_cloudManager.UploadSaveGame($"{ Application.persistentDataPath }/{ PlayerInfoFileName }");
			}
		}
	}
}
