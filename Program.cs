/* Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

System.Console.Write($"Введите значение N: ");
int n = Convert.ToInt16(Console.ReadLine());

//int count = 1;
string result = string.Empty;

string Recurse(int n)
{
    if (n == 1) result = result + $"{n}";

    if (n > 1)
    {
        result = result + $"{n}, ";
        return Recurse(n - 1);
    }

    return result;
}

Recurse(n);
System.Console.Write($"N = {n} - > \"{result}\"");


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

System.Console.Write($"Введите значение M: ");
int m = Convert.ToInt16(Console.ReadLine());

System.Console.Write($"Введите значение N: ");
int n = Convert.ToInt16(Console.ReadLine());

int count = 0;

int Recurse(int m, int n)
{
    if (m <= n)
    {
        count = count + m;
        Recurse(m + 1, n);
    }
    return count;
}

Recurse(m, n);
System.Console.Write($"M = {m}, N = {n} - > {count}");

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

System.Console.Write($"Введите значение M: ");
int m = Convert.ToInt16(Console.ReadLine());
System.Console.Write($"Введите значение N: ");
int n = Convert.ToInt16(Console.ReadLine());

int Recurse(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m != 0 && n == 0) return Recurse(m - 1, 1);
        else
        {
            return Recurse(m - 1, Recurse(m, n - 1));
        }
    }
}

System.Console.Write($"M = {m}, N = {n} -> A(m,n) = {Recurse(m, n)}");
