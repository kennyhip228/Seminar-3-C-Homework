//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());

while (number<1)
{
    Console.WriteLine("Вы ввели неверное число");
    Console.Write("Введите натуральное число: ");
    number = int.Parse(Console.ReadLine());
}

for (int i = 1; i <= number; i++)
    Console.Write($"{Math.Pow(i, 3)}, ");