// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

int num = new Random().Next(100, 1000);
string num1 = num.ToString();
Console.WriteLine($"Число: {num}");
Console.Write($"Вторая цифра числа: {num1[1]}");