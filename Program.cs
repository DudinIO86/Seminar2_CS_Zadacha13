// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать массив
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

//определение кол-ва числе в числе
int n = num / 10;
int index = 1;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int i = 0;
int step = 10;
int n1 = 1;

while (n > 0)
{
    n = n / 10;
    index++;
}

if (index > 2)
{
    for (i = 0; i < (index - 3); i++)
    {
        step = step * 10;
    }

    num3 = num % step;
    if (num3 > 9)
    {
        index = 1;
        n1 = num3 / 10;
        while (n1 > 0)
        {
            n1 = n1 / 10;
            index++;
        }

        step = 10;

        for (i = 0; i < (index - 2); i++)
        {
            step = step * 10;
        }
        num4 = num3 / step;
        Console.WriteLine($"Третья цифра числа {num} является {num4}");
    }
    else
    {
        num4 = num3;
        Console.WriteLine($"Третья цифра числа {num} является {num4}");
    }
}
else
{
    Console.WriteLine("У числа нет третьей цифры");
}
