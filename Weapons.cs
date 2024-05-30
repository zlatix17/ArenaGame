using System;

public class Weapons:Hero
{
    public string type { get; private set; }

    public string name { get; private set; }

    public int damage { get; private set; }

    public override Attack()
    {
        Console.WriteLine($"Using {name} it just took of {damage} damage!");
    }
}
