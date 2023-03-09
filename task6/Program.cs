//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число:");
int num = Convert.ToInt32( Console.ReadLine());
int res = 0;
res = (num % 2);
Console.WriteLine("Является ли введенное число четным? ");
if (res == 0)
    {
    Console.WriteLine("Да");
    }
else
    Console.WriteLine("Нет");
