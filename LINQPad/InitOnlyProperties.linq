<Query Kind="Program" />

public class InitOnly
{
	public string? Name { get; init; }
	public int Id { get; init; }
}

public static void Main()
{
	InitOnly initOnly = new InitOnly
	{
		Name = "Name1",
		Id = 1
	};

	// initOnly.Name = "Name2"; // ERROR: Cannot set property outside of object initializer.
}