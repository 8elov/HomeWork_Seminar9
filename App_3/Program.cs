// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindAckerman(m,n));

int FindAckerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return FindAckerman(n - 1, 1);
        }
        else
        {
            return FindAckerman(n - 1, FindAckerman(n, m - 1));
        }
    }
}
