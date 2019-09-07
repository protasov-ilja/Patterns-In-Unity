using UnityEngine;

namespace Patterns.DI
{
	public class NitroEngine : IEngine
	{
		public void Start()
		{
			OpenNitroValve();
			Debug.Log("Engine started");
		}

		private void OpenNitroValve()
		{
			Debug.Log("The nitro valve is open");
		}
	}
}
