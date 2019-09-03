namespace Patterns.Decorator
{
	public abstract class RifleDecorator : IRifle
	{
		protected IRifle _decoratedRifle;

		public RifleDecorator(IRifle rifle)
		{
			_decoratedRifle = rifle;
		}

		public virtual float GetAccuracy()
		{
			return _decoratedRifle.GetAccuracy();
		}
	}
}
