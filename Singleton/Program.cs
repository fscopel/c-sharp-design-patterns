using Singleton;

var one = ThereCanBeOnlyOne.Instance;
var two = ThereCanBeOnlyOne.Instance;
one.Value++;
Console.WriteLine($"{two.Value}");
two.Value++;
Console.WriteLine($"{one.Value}");

Console.ReadLine();
