// Урок 4. Функции
// Сдавать ссылкой на github
//**********************************************************
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//
// int f(int a, int b)
// {
//     int res=1;
// for (int i =1; i <= b; i++)
// {
//   res  = res *a;  
//   
// }
// return res;

// }
// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write(f(a, b));
//***********************************
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//
// int f(int a)
// {
//     int res=0;
// while (a > 0)
// {
//   res  = res + a%10;
//   a = a / 10;  
//   
// }
// return res;

// }
// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write(f(a));
//***************************************************************
// Задача 29: Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]


void farr(int a)
{
   int[] arr = new int[a];
   Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine($"[{string.Join(", ", arr)}]");
}
Console.Write("Введите длинну массива: ");
int a = Convert.ToInt32(Console.ReadLine());

farr(a);