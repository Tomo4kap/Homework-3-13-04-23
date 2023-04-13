// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите номер дня недели: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 == 6 | number1 == 7)
    Console.WriteLine("WEEKEND");
if (number1 == 1 | number1 == 2 | number1 == 3 | number1 == 4 | number1 == 5)
    Console.WriteLine("WORKING DAY");
if (number1 > 7)
    Console.WriteLine("Такого дня недели не существует");