using Patterns.Strategy.Missiles;
using Patterns.Strategy.SeekBehaviours;
using UnityEngine;

namespace Patterns.Strategy
{
	public sealed class ClientStrategy : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.D))
			{
				// Applying default seeking behaviour to missiles.
				var sideWinder = ScriptableObject.CreateInstance<SideWinder>();
				sideWinder.ApplySeek();
				var tomahawk = ScriptableObject.CreateInstance<Tomahawk>();
				tomahawk.ApplySeek();
				var torpedo = ScriptableObject.CreateInstance<Torpedo>();
				torpedo.ApplySeek();

				// Applying custom seeking behaviour to a SideWinder.
				var sideWinderWithSonar = ScriptableObject.CreateInstance<SideWinder>();
				ISeekBehaviour sonar = new SeekWithSonar();
				sideWinderWithSonar.SetSeekBehavior(sonar);
				sideWinderWithSonar.ApplySeek();
			}
		}
	}
}
