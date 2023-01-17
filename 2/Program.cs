// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (b == a * a)
{
    Console.WriteLine("Второе число является квадратом первого числа");
}
if (a == b * b)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}