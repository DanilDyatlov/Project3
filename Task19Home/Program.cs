// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное натуральное число:");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number >= 10000 && number < 100000)
{
    int fistDigit1 = number / 10000;
    int secondDigit = number % 10;
        if (fistDigit1 == secondDigit)
        {
            number = number / 10;
            int fistDigit2 = number / 100 % 10;
            int secondDigit2 = number % 10;
                if (fistDigit2 == secondDigit2)
                {
                    Console.WriteLine("Да");
                }
                else Console.WriteLine("Нет");
        }
        else Console.WriteLine("Нет");
}
else Console.WriteLine("Неверный ввод");