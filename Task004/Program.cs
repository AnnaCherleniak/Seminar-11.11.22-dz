// Написать программу возведения числа А в целую стень B

int Power(int a, int b)
{
    if(b == 0) return 1;
    else if( b % 2 == 0) return Power(a * a, b / 2);
    else return Power(a, b - 1) * a;
}
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень (В), в которую возвести число А: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("А в степени В равно: ");
Console.WriteLine(Power(a, b));