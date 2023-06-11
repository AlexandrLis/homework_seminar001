//Задание1

Console.WriteLine("Введите два числа");
Console.WriteLine("Первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
    {
        Console.WriteLine("Оба числа одинаковые: " + num1);
    }
else if (num1 > num2)
    {
        Console.WriteLine("Максимальное число: " + num1);
    }
else if (num1 < num2)
    {
        Console.WriteLine("Максимальное число: " + num2);
    }



