namespace DotNet5Samples.TargetTyping.NullCoalescenceExpressions.Data
{
	public abstract class User
	{
		public override string ToString() => GetType().Name;
	}
}