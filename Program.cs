// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string PrintNumber(int i, int num)
{
    if (i < num) return ($"{i} " + PrintNumber(i + 1, num));
    else return Convert.ToString(num);
}

Console.Clear();
Console.WriteLine("Введите значение M (целое, положительное):");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N (целое, положительное) и больше M!!!:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа в промежутке от {number1} до {number2}:");
Console.WriteLine(PrintNumber(number1, number2));