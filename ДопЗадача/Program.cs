//Напишите программу, которая по заданному номеру четверти, показывает ее диапозон возможных координат.

void Coordinats(int quart)
{
    if (quart == 1)
        Console.WriteLine("0 < x < endless, 0 < y < endless");
    else if (quart == 2)
        Console.WriteLine("-endless < x < 0, 0 < y < endless");
    else if (quart == 3)
        Console.WriteLine("-endless < x < 0, -endless < y < 0");
    else if (quart == 4)
        Console.WriteLine("0 < x < endless, -endless < y < 0");
}
Console.Write("Input quart: ");
int qu = Convert.ToInt32(Console.ReadLine());
Coordinats(qu);