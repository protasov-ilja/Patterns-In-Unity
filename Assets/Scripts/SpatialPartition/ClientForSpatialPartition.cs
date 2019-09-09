using UnityEngine;

namespace Assets.Scripts.SpatialPartition
{
	public class ClientForSpatialPartition : MonoBehaviour
	{
		private Grid _grid;
		private IUnit[] _preys;

		private void Start()
		{
			_grid = new Grid(4, 16);

			Debug.Log("Grid generated");
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				IUnit prey;
				int numberOfPreys = 5;
				_preys = new IUnit[numberOfPreys];
				for (var i = 0; i < numberOfPreys; ++i)
				{
					prey = new Prey();
					_grid.AddToRandomPosition(prey);
					_preys[i] = prey;
					Debug.Log($"A prey was spawned @ square: { _preys[i].GetGridPosition() }");
				}
			}

			if (Input.GetKeyDown(KeyCode.H))
			{
				IUnit predator;
				predator = new Predator();
				_grid.AddToRandomPosition(predator);

				Debug.Log($"A predator was spawned @ square: { predator.GetGridPosition() }");

				int closest = _grid.FindClosest(predator, _preys);

				Debug.Log($"The closest prey @ square: { closest }");
			}
		}

		private void OnGUI()
		{
			GUI.color = Color.black;
			GUI.Label(new Rect(10, 10, 500, 20), "Press P to spawn prey on the grid.");
			GUI.Label(new Rect(10, 30, 500, 20), "Press H to hunt some prey.");
			GUI.Label(new Rect(10, 50, 500, 20), "Open Debug Console to view the output.");
		}
	}
}
