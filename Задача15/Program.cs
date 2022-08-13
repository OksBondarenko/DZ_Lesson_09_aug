//Задача 15
//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend(int num)
{
    bool result = false;
    if (num == 6 || num == 7)
        result = true;
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Weekend(number));
