using Patterns.Decorator.Decorators;
using UnityEngine;

namespace Patterns.Decorator
{
	public sealed class DecoratorClient : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.B))
			{
				IRifle rifle = new BasicRifle();

				Debug.Log($"basic accuracy: { rifle.GetAccuracy() }");
			}

			if (Input.GetKeyDown(KeyCode.S))
			{
				IRifle rifle = new BasicRifle();
				rifle = new WithScope(rifle);

				Debug.Log($"WithScope accuracy { rifle.GetAccuracy() }");
			}

			if (Input.GetKeyDown(KeyCode.T))
			{
				IRifle rifle = new BasicRifle();
				rifle = new WithScope(new WithStabilizer(rifle));

				Debug.Log($"Stabilizer+Scope accuracy { rifle.GetAccuracy() }");
			}
		}
	}
}
