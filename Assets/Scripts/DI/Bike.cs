using UnityEngine;

namespace Patterns.DI
{
	public class Bike : MonoBehaviour
	{
		public enum EngineType
		{
			Jet, 
			Turbo,
			Nitro
		};

		public enum DriverType
		{
			Human,
			Android
		};

		private IEngine _engine;
		private IDriver _driver;

		// Setter injection
		public void SetEngine(IEngine engine)
		{
			_engine = engine;

			Debug.Log($"The bike is running with the engine: { _engine }");
		}

		// Setter injection
		public void SetDirver(IDriver driver)
		{
			_driver = driver;

			Debug.Log($"the driver of the bike is a: { _driver }");
		}

		public void StartEngine()
		{
			if (_engine != null)
			{
				// Start the bike's engine
				_engine.Start();
				// Give control of the bike to the driver
				_driver.Control(this);
			}
		}

		public void TurnLeft()
		{
			Debug.Log("The bike is turning left");
		}

		public void TurnRight()
		{
			Debug.Log("The bike is turning right");
		}
	}
}
