// Найти сумму элементов от M до N, N и M заданы
int Sum(int min, int max)
{
    if(max >= min) return max + Sum(min, max - 1);
    else return 0;
}
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Сумма элементов от М до N: ");
if(m < n)
    Console.WriteLine(Sum(m, n));
else if(m > n)
    Console.WriteLine(Sum(n, m));
else
    Console.WriteLine(); 