using UnityEngine;

namespace Patterns.DI
{
	public sealed class ClientDI : MonoBehaviour
	{
		[SerializeField] private Bike _playerBike;

		[SerializeField] private Bike _androidBike;

		private void Awake()
		{
			// Set up a bike with a human driver and jet engine
			var jetEngine = new JetEngine();
			var humanDriver = new HumanDriver();

			_playerBike.SetEngine(jetEngine);
			_playerBike.SetDirver(humanDriver);
			_playerBike.StartEngine();

			// Set up a bike with a AI driver and a nitro engine
			var nitroEngine = new NitroEngine();
			var androidDriver = new AndroidDriver();

			_androidBike.SetEngine(nitroEngine);
			_androidBike.SetDirver(androidDriver);
			_androidBike.StartEngine();
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.A))
			{
				_playerBike.TurnLeft();
			}

			if (Input.GetKeyDown(KeyCode.D))
			{
				_playerBike.TurnRight();
			}
		}

		private void OnGUI()
		{
			GUI.color = Color.black;
			GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
			GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console");
		}
	}
}
