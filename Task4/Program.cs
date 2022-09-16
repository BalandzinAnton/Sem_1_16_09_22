Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = -num1;
while (num1 >= num2)
{
    Console.WriteLine($"{num2}");
    num2++;
}
