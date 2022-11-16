//  Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int Fibonacci(int a, int b)
{
    return a + Fibonacci(b, a + b);
}
Console.WriteLine("Введите первый элемент последовательности: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второй элемент последовательности: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int n = 10;
/*for(int i = 1; i < n; i++)
{
    int temp = a + b;
    Console.WriteLine(temp);
    a = b;
    b = temp;
}*/
for(int i = 1; i < n; i++)
{
    Console.WriteLine(Fibonacci(a, b));
}