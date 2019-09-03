namespace Patterns.Decorator
{
	public class BasicRifle : IRifle
	{
		private float _basicAccuracy = 5.0f;

		public float GetAccuracy()
		{
			return _basicAccuracy;
		}
	}
}
