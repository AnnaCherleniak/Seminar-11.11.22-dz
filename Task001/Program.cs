// Показать натуральные числа от M до N, N и M заданы

string NumbersMLessN(int m, int n)
{
    if(m <= n) return $"{m} " + NumbersMLessN(m + 1, n);
    else return String.Empty;
}
string NumbersMMoreN(int m, int n)
{
    if(m >= n) return $"{m} " + NumbersMMoreN(m - 1, n);
    else return String.Empty;
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Натуральные числа от {m} до {n}: ");
if(m < n)
    Console.WriteLine(NumbersMLessN(m, n));
else if(m > n)
    Console.WriteLine(NumbersMMoreN(m, n));
else
    Console.WriteLine(); 