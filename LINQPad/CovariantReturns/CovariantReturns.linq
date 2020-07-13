<Query Kind="Program" />

public abstract class Animal
{
    public abstract Food GetFood();
}

public class Tiger : Animal
{
    public override Meat GetFood()
		=> new Meat();
}

public abstract class Food
{
}

public class Meat : Food
{
}