// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите натуральное число:");
int number = Convert.ToInt32(System.Console.ReadLine());

if(number > 0)
{
    TableCubes(number);
}
else Console.WriteLine ("Не натуральное число");

void TableCubes(int num)
{
    int count = 1;
    while (count <= num)
    {
        // Console.WriteLine($"{count}\t" + Math.Pow(count, 3));
        Console.WriteLine($"{count,1}{Math.Pow(count, 3),8}");
        count++;
    }
}
