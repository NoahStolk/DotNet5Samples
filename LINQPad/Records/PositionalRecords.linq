<Query Kind="Program" />

public record Record(string Name, int Id);

public static void Main()
{
	Record record1 = new Record("X", 1);
	
	(string name, int id) = record1;
	
	Console.WriteLine(name);
	Console.WriteLine(id);
}