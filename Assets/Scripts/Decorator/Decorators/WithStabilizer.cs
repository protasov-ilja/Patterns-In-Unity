namespace Patterns.Decorator.Decorators
{
	public class WithStabilizer : RifleDecorator
	{
		private float _stabilizerAccuracy = 10.0f;

		public WithStabilizer(IRifle rifle)
			: base(rifle)
		{ }

		public override float GetAccuracy()
		{
			return base.GetAccuracy() + _stabilizerAccuracy;
		}
	}
}
