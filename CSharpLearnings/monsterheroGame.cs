Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    if(current>=8) continue;
    Console.WriteLine(current);
} while (current != 7);

int hero=10;
int monster=10;

Random hh = new Random();
do{
    int roll = hh.Next(1,11);
    monster-=roll;
    Console.WriteLine($"Monsters health was decreased by {roll} points, new health {monster}");

    if (monster <= 0) continue;

    roll = hh.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
}while(hero>0 && monster>0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
