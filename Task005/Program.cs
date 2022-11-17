//  Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

int SequenceOfElements(int a, int b, int n)
{
    if(n == 1) 
        return a;
    else if(n == 2)
        return b;
    else if(n == 3)
        return a + b;
    else
        return SequenceOfElements(b, a + b, n - 1); 
}
int ReadIntegerMessage(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int a = ReadIntegerMessage("Введите первый элемент последовательности: ");
int b = ReadIntegerMessage("Введите второй элемент последовательности: ");
int n = ReadIntegerMessage("Введите сколько элементов будет в последовательности: ");
Console.WriteLine();
for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}  {SequenceOfElements(a, b, i)}");
}

