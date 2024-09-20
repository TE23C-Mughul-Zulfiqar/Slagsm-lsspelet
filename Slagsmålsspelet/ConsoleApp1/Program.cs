int player1Hp = 100;
int player2Hp = 100;

string player1Name = "HJÄLTE";
string player2Name = "FIENDE";

Random generator = new Random();

while (player1Hp > 0 && player2Hp > 0)
{
    Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
  Console.WriteLine($"{player1Name}: {player1Hp}  {player2Name}: {player2Hp}\n");

  int player1Damage = generator.Next(25);
  player2Hp -= player1Damage;
  player2Hp = Math.Max(0, player2Hp);
  Console.WriteLine($"{player1Name} gör {player1Damage} skada på {player2Name}");

int player2Damage = generator.Next(25);
  player1Hp -= player2Damage;
  player1Hp = Math.Max(0, player1Hp);
  Console.WriteLine($"{player2Name} gör {player2Damage} skada på {player2Name}");

  Console.WriteLine("Tryck på ENTER för att fortsätta");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== KAMPEN ÄR ÖVER! ===== -----");

if (player1Hp == 0 && player2Hp == 0)
{
    Console.WriteLine("Ingen vinner");
}
    else if (player1Hp == 0)
{
    Console.WriteLine($"{player2Name} vann");
}
else
{
    Console.WriteLine($"{player1Name} vann");
}
Console.WriteLine("Tryck på vad som helst för att stänga");
Console.ReadKey();