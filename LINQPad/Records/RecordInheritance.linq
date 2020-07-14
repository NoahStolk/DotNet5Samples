<Query Kind="Program" />

public record Record
{
	public string? Name { get; init; }
	public int Id { get; init; }
}

public record DerivedRecord : Record
{
	public int Code { get; init; }
}

public static void Main()
{
	Record record = new Record
	{
		Name = "X",
		Id = 1
	};
	
	DerivedRecord derivedRecord = new DerivedRecord
	{
		Name = "X",
		Id = 1,
		Code = 2
	};
	
	Console.WriteLine(derivedRecord.Equals(record)); // False, not the same type
	Console.WriteLine(record.Equals(derivedRecord)); // False, not the same type
}