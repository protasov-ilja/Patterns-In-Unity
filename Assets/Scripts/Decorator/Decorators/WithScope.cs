namespace Patterns.Decorator.Decorators
{
	public class WithScope : RifleDecorator
	{
		private float _scopeAccuracy = 20.0f;

		public WithScope(IRifle rifle) 
			: base(rifle)
		{ }

		public override float GetAccuracy()
		{
			return base.GetAccuracy() + _scopeAccuracy;
		}
	}
}
