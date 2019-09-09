using System;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.SpatialPartition
{
	public class Grid : MonoBehaviour
	{
		private int _squareSize;
		private int _numberOfSquares;

		public Grid(int squareSize, int numberOfSquares)
		{
			// The size can represent anything (meters, km)
			_squareSize = squareSize;
			// squares permits to subdivide the grid granualy
			_numberOfSquares = numberOfSquares;
		}

		public void AddToRandomPosition(IUnit unit)
		{
			unit.AddToGrid(UnityEngine.Random.Range(0, _numberOfSquares));
		}

		public int FindClosest(IUnit referenceUnit, IUnit[] list)
		{
			if (list != null)
			{
				// Using LINQ queries
				var points = list.Select(a => a.GetGridPosition()).ToList();
				var nearest = points.OrderBy(x => Math.Abs(x - referenceUnit.GetGridPosition())).First();

				return nearest;
			}
			else
			{
				throw new ArgumentException("Parameters cannot be null", "list");
			}
		}
	}
}
