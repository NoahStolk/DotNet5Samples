<Query Kind="Program" />

public record Record
{
	public string? Name { get; init; }
	public int Id { get; init; }
}

public record DerivedRecord : Record
{
	public int Code { get; init; }

	protected override Type EqualityContract => typeof(Record);
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
	
	Console.WriteLine(record.Equals(derivedRecord)); // True, overridden EqualityContract
	Console.WriteLine(derivedRecord.Equals(record)); // False, overridden EqualityContract, but not the same Code value
}