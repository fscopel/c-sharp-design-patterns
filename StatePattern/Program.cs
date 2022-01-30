using StatePattern;

var gb = new GumballMachine(5);
Console.WriteLine($"Gumballs available: {gb.GumballCount}");
gb.InsertCoin();
gb.turnCrank();

Console.WriteLine($"Gumballs available: {gb.GumballCount}");
gb.InsertCoin();
gb.turnCrank();
gb.InsertCoin();
gb.turnCrank();

Console.WriteLine($"Gumballs available: {gb.GumballCount}");

Console.ReadLine();
