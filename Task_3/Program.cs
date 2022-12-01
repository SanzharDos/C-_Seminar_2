// Задача №12

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
int num1 = new Random().Next(10, 100);
int num2 = new Random().Next(1, 10);
Console.WriteLine($"Сгенерировано первое число {num1} и второе число {num2}");
int x = num1 / num2;
if (num1 == x * num2) // (num1 % num2 == 0)
{
    Console.WriteLine($"Второе число кратно первому - в {x} раз"); // Console.WriteLine($"Второе число кратно первому в {num1 / num2} раз");
}
else
{
    int y = num1 % num2;
    Console.WriteLine($"Второе число не кратно первому, остаток первого числа от второго равен {y}");
}