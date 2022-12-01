// Задача №11
int num = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное число - {num}");
int x1 = num / 100;
int x2 = num % 10;
Console.Write($"Без второй цифры это {x1}{x2}");
