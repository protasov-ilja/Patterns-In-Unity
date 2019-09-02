using UnityEngine;

namespace Patterns.Facade.SubModules
{
	public sealed class ScoreManager
	{
		public int GetScore(int playerId)
		{
			Debug.Log("Returning player score.");
			return 0;
		}
	}
}
