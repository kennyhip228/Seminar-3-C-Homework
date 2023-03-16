// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;

while (number.Length > 5 || number.Length < 5)
{
    Console.WriteLine("Вы ввели неверное число");
    Console.Write("Введите пятизначное число: ");
    number = Console.ReadLine()!;
}

int count = 0;

for (int i = 0; i < (number.Length / 2); i++)
{
    if (number[i] == number[(number.Length-1)-i])
        count = count + 1;
}

if (count == (number.Length / 2))
    Console.WriteLine("Это число является палиндромом");
else
    Console.WriteLine("Это число не является палиндромом");

