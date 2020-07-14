<Query Kind="Program" />

public record Record
{
	public string? Name { get; init; }
	public int Id { get; init; }
}

public static void Main()
{
	Record record1 = new Record
	{
		Name = "X",
		Id = 1
	};
	
	Record record2 = new Record
	{
		Name = "X",
		Id = 1
	};

	Console.WriteLine(record2.Equals(record1)); // True; value-based equality
	Console.WriteLine(record2 == record1); // False; not the same reference
	Console.WriteLine(ReferenceEquals(record2, record1)); // False; not the same reference
}