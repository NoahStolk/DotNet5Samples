using DotNet5Samples.TargetTyping.NullCoalescenceExpressions.Data;
using System;

namespace DotNet5Samples.TargetTyping.NullCoalescenceExpressions
{
	public class NullCoalescenceExpressionsSample : ISample
	{
		private readonly Supplier supplier = new Supplier();
		private readonly Customer customer = null;

		public void RunCSharp8()
		{
			Console.WriteLine((User)customer ?? supplier);
			Console.WriteLine(true ? (int?)0 : null);
		}

		public void RunCSharp9()
		{
			throw new NotImplementedException("C# 9.0 feature not yet supported...");
#if TARGET_TYPED_NULL_COALESCENCE_EXPRESSIONS
			Console.WriteLine(customer ?? supplier);
			Console.WriteLine(true ? 0 : null);
#endif
		}
	}
}