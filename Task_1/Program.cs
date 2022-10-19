// Напишите программу, которая принимает на вход трёхзначное число и на входе показывает вторую цифру этого числа. Не использовать строки для расчета.ы
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Promt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 100 || number >= 1000)
    {
        System.Console.WriteLine($"Число {number} не трехзначное");
        return false;
    }
    return true;
}

int number = Promt("Введите трехзначное число: ");
if (ValidateNumber(number))
{
    int SecondDigit = (number / 10) % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна {SecondDigit}");
}