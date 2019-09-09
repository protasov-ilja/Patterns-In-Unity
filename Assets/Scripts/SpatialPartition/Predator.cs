﻿using UnityEngine;

namespace Assets.Scripts.SpatialPartition
{
	public class Predator : MonoBehaviour, IUnit
	{
		private int _square;
		public void AddToGrid(int cell)
		{
			_square = cell;
		}

		public int GetGridPosition()
		{
			return _square;
		}
	}
}
