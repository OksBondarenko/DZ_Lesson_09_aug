//Задача 10
//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int SecondDigit(int number)
{
    int secDigit;
    number = Math.Abs(number);
    if (number > 99 && number < 1000)
    {
        secDigit = number / 10 % 10;
        return secDigit;
    }
    else
    {
        secDigit = -1;
        return secDigit;
    }
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (SecondDigit(num)> -1)
    Console.WriteLine(SecondDigit(num));
else
    Console.WriteLine("Введено не трехзначное число!");