using UnityEngine;

namespace Patterns.DI
{
	public class JetEngine : IEngine
	{
		public void Start()
		{
			ActivateJetStream();
			Debug.Log("Engine started");
		}

		private void ActivateJetStream()
		{
			Debug.Log("The jet stream is activated");
		}
	}
}
