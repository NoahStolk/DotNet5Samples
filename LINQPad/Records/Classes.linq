<Query Kind="Program" />

public class Class
{
	public string? Name { get; set; }
	public int Id { get; init; }
}

public static void Main()
{
	Class class1 = new Class
	{
		Name = "Name1",
		Id = 1
	};
	
	Class class2 = class1;
	class2.Name = "Name2";
	
	Console.WriteLine(class2.Equals(class1)); // True
	Console.WriteLine(class2 == class1); // True
	Console.WriteLine(ReferenceEquals(class2, class1)); // True
}