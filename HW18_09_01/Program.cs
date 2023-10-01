// See https://aka.ms/new-console-template for more information
//Первая задача.
Console.WriteLine("Введите целое число:");
int number = int.Parse(Console.ReadLine());
int res = number % 8;
Console.WriteLine($"{res}");
Console.WriteLine("                               ");
// Вторая задача.
Console.WriteLine("Вторая задача:");
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 = int.Parse(Console.ReadLine());
int sum = num1 + num2 + num3;
int proiz = num1 * num2 * num3;
Console.WriteLine($"Сумма чисел составляет: {sum}");
Console.WriteLine($"Произведение чисел составляет: {proiz}");
