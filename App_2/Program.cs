// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowNumbers(m,n));

int ShowNumbers(int m, int n)
{
    int sum = 0;
    sum += m;

    if (m == n)
    {
        return sum;
    }
    return sum + ShowNumbers(m + 1, n);
}

