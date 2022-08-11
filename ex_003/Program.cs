// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int days = new Random().Next(1, 8);
if(days > 5)
{
    Console.WriteLine($"День недели: {days}") ;
    Console.WriteLine("Сегодня выходной");
}
else
{
    Console.WriteLine($"День недели: {days}") ;
    Console.WriteLine($"Сегодня рабочий день"); 
}
