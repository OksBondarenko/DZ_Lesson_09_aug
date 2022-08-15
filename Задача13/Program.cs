//Задача 13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int ThirdNumber (int num)
{
    num = Math.Abs(num);
    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
    }
    else
    {
        num = -1;
    }
    return num;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (ThirdNumber(number)> -1)
    Console.WriteLine(ThirdNumber(number));
else
    Console.WriteLine("Ошибка! Третьей цифры нет!");