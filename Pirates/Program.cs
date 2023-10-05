using Pirates;

List<Pirate> pirates = new List<Pirate>();

Pirate p1 = new Pirate("Zoro");
Pirate p2 = new Pirate("Luffy");
Pirate p3 = new Pirate("Usopp");
Pirate p4 = new Pirate("Nami");
Pirate p5 = new Pirate("Gol D. Roger");

pirates.Add(p1);
pirates.Add(p2);
pirates.Add(p3);
pirates.Add(p4);
pirates.Add(p5);

for (int i = 0; i < 30; i++)
{
	Random rnd = new Random();
	int drink = rnd.Next(1,6);
	switch (drink)
	{
		case 1:
			p1.drinkSomeRum();
			break;
		case 2:
			p2.drinkSomeRum();
			break;
		case 3:
			p3.drinkSomeRum();
			break;
		case 4:
			p4.drinkSomeRum();
			break;
		case 5:
			p5.drinkSomeRum();
			break;
	}
}
for (int i = 0; i < pirates.Count; i++)
{
	Console.WriteLine(pirates[i].howItsGoingMate());
}
Console.ReadKey();

