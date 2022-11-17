//  Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int Sum(int a, int b)
{
    return a + b;

}
Console.WriteLine("Введите первый элемент последовательности: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второй элемент последовательности: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int n = 10;
Console.WriteLine();
/*for(int i = 1; i < n; i++)
{
    int temp = a + b;
    Console.WriteLine(temp);
    a = b;
    b = temp;
}*/

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}  {Sum(a, b)}");
    int temp = b;
    b = Sum(a, b);
    a = temp;
}
