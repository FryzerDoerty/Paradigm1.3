//Задача 3: Вычисление факториала числа. Напишите программу, которая находит факториал заданного числа N с использованием рекурсии или встроенных 
//функций. Декларативный
int Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}
System.Console.WriteLine("Введите число для нахождения факториала: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = Factorial(n);
System.Console.WriteLine(a);