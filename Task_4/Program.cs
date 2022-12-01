// Задача - напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

int num = new Random().Next();
Console.WriteLine($"Сгенерировано случайное число - {num}");
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($"Число {num} одновременно кратно 7 и 23");
}
else if (num % 7 == 0 && num % 23 != 0)
{
    Console.WriteLine($"Число {num} кратно 7");
}
else if (num % 7 != 0 && num % 23 == 0)
{
    Console.WriteLine($"Число {num} кратно 23");
}
else
{
    Console.WriteLine($"Число {num} не кратно 7 и 23");
}