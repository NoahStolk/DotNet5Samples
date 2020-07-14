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
	
	Record record2 = record1 with { Name = "Y" };

	Console.WriteLine(record2.Equals(record1)); // False; value-based equality
	Console.WriteLine(record2 == record1); // False; not the same reference
	Console.WriteLine(ReferenceEquals(record2, record1)); // False; not the same reference
	Console.WriteLine();
	
	Record record3 = record2 with { Name = "X" };

	Console.WriteLine(record3.Equals(record1)); // True; value-based equality
	Console.WriteLine(record3 == record1); // False; not the same reference
	Console.WriteLine(ReferenceEquals(record3, record1)); // False; not the same reference
}