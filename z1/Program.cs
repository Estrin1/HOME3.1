// Задача 25: Используя определение степени числа, напишите цикл, 
//который принимает на вход два натуральных числа (A и B) и возводит 
//число A в степень B. 3, 5 -> 243 (3⁵) 2, 4 -> 16
void Zadacha1 ()
{
Console.WriteLine("Напишите входные числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = a;
for (int i = 1; i < b; i++) 
{
a = a * c;
Console.WriteLine(a);
}
}
Zadacha1();