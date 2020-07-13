<Query Kind="Program" />

public struct Struct
{
	public string Name { get; set; }
	public int Id { get; init; }
	
	public static bool operator ==(Struct left, Struct right)
		=> left.Equals(right);
	
	public static bool operator !=(Struct left, Struct right)
		=> !(left == right);
	
	public override bool Equals(object? obj)
	{
		if (obj is not Struct s)
			return false;
		return Name == s.Name && Id == s.Id;
	}
	
	public override int GetHashCode()
		=> HashCode.Combine(Name, Id);
}

public static void Main()
{
	Struct struct1 = new Struct
	{
		Name = "Name1",
		Id = 1
	};
	
	Struct struct2 = struct1;
	struct2.Name = "Name2";
	
	Console.WriteLine(struct2.Equals(struct1)); // False
	Console.WriteLine(struct2 == struct1); // False
	Console.WriteLine(ReferenceEquals(struct2, struct1)); // False
}