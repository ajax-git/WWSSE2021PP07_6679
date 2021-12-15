/*
   Napisz program, który dla zadanej liczby całkowitej dodatniej oblicza jej reprezentację szestnastkową.
*/

Console.WriteLine("Podaj liczbę całkowitą dodatnią: ");

int number = Convert.ToInt32(Console.ReadLine());

while(number < 0)
{
    Console.WriteLine("Podaj liczbę całkowitą dodatnią: ");

    number = Convert.ToInt32(Console.ReadLine());
}

string hex = number.ToString("X");
Console.WriteLine("Reprezentacja szesnastkowa liczby {0} wynosi: {1}.", number, hex);