// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

int num = new Random().Next(10, 1000);
int lastDigit = num % 10;

if(num < 100)
{
    Console.Write($"Число {num} - двузначное, третьего числа не существует. ");
}
else
{
    Console.WriteLine($"Число: {num}");
    Console.Write($"Третья цифра {lastDigit}");
}