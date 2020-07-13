namespace DotNet5Samples.TargetTyping.NewExpressions.Data
{
	public struct Coordinate
	{
		public Coordinate(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public float X { get; set; }
		public float Y { get; set; }
		public float Z { get; set; }

		public override string ToString()
			=> $"[{X},{Y},{Z}]";
	}
}