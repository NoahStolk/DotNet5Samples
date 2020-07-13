<Query Kind="Program" />

public record Record
{
	public string? Name { get; set; }
	public int Id { get; init; }
}

public static void Main()
{
	Record record1 = new Record
	{
		Name = "Name1",
		Id = 1
	};

	Record record2 = record1;
	record2.Name = "Name2";

	Console.WriteLine(record2.Equals(record1)); // True
	Console.WriteLine(record2 == record1); // True
	Console.WriteLine(ReferenceEquals(record2, record1)); // True
}