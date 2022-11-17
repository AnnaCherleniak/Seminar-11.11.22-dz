//  Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int Sum(int a, int b, int n)
{
    if(n == 1) 
        return a;
    else if(n == 2)
        return b;
    else if(n == 3)
        return a + b;
    else
        return Sum(b, a + b, n - 1); 
}
Console.WriteLine("Введите первый элемент последовательности: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второй элемент последовательности: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int n = 8;
Console.WriteLine();

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}  {Sum(a, b, i)}");
}

