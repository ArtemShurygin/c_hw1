//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int counter = 1;
int res = 0;
while (counter < num)
    {
    res = (counter % 2);
    if (res == 0)
        {
        Console.Write(counter + "  ");
        }
    counter = counter + 1;
    }
