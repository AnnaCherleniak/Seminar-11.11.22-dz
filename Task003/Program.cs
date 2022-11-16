// Написать программу вычисления функции Аккермана

int Akkermana(int m, int n)
{
    if(m == 0) 
        return n + 1;
    else if(m == 1)
        return n + 2;
    else if(m == 2)
        return 2 * n + 3;
    else if(n == 0) 
        return Akkermana(m - 1, 1);
    else
        return Akkermana(m - 1, Akkermana(m, n - 1));
}
Console.WriteLine("Введите первое неотрицательное целое число:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе неотрицательное целое число:");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Значение функции Аккермана: ");
Console.WriteLine(Akkermana(m, n));