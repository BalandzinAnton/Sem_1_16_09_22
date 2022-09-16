Console.Clear();
Console.Write("Введите числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int sqr = Convert.ToInt32(Math.Pow(num2,2));
if (num1 == sqr)
{
    Console.WriteLine("Является");
}
else 
{
    Console.WriteLine("Не является");
}
