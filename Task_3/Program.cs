// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string text)
{
    System.Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int NumberDigit(int number)
{
    int count = 0;
    while (Math.Abs(number) > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
int number = Prompt("Введите целое число: ");
int numDigit = NumberDigit(number);
int num = Math.Abs(number);
if (numDigit <= 2)
{
    Console.WriteLine($"У числа {number} третьей цифры нет");
}
else
{
    if (numDigit > 3)
    {
        num = num / Convert.ToInt32(Math.Pow(10, numDigit - 3));
    }
    int thirdDigit = num % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {thirdDigit}");
}