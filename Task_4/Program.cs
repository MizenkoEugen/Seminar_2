// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string text)
{
    System.Console.Write(text);
    int day = Convert.ToInt32(Console.ReadLine());
    return day;
}
int day = Prompt("Введите цифру, обозначающую день недели: ");
if (day >= 6 & day <= 7)
{
    Console.WriteLine($"{day} выходной день -> да");
}
else
{
    if (day >= 1 & day <= 5)
    {
        Console.WriteLine($"{day} выходной день -> нет");
    }
    else
    {
        Console.WriteLine($"{day} не является днем недели");
    }
}