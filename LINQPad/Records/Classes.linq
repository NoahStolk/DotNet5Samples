<Query Kind="Program" />

public class Class
{
	public string? Name { get; init; }
	public int Id { get; init; }
}

public static void Main()
{
	Class class1 = new Class
	{
		Name = "X",
		Id = 1
	};
	
	Class class2 = new Class
	{
		Name = "X",
		Id = 1
	};
	
	Console.WriteLine(class2.Equals(class1)); // False; not the same reference
	Console.WriteLine(class2 == class1); // False; not the same reference
	Console.WriteLine(ReferenceEquals(class2, class1)); // False; not the same reference
}