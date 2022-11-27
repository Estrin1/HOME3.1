//Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11 82 -> 10 9012 -> 12

Console.WriteLine("Введите число");
var a = Convert.ToInt32(Console.ReadLine());
int summ = 0;
while ( a >= 1)
{
    summ = summ + a % 10;
    a = a / 10;
}
Console.WriteLine("Write the summ > " + summ);
