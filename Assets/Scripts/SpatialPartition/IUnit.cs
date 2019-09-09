namespace Assets.Scripts.SpatialPartition
{
	public interface IUnit
	{
		// The Unit can add itself to the grid
		void AddToGrid(int cell);
		// THe Unit can return it current grid position
		int GetGridPosition();
	}
}
