//Задание2

Console.WriteLine("Введите три числа");
Console.WriteLine("Первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 && num1 == num3)
    {
        Console.WriteLine("Все числа одинаковые: " + num1);
    }
if (num1 == num2)
    {
        if (num1 > num3)
            {
                Console.WriteLine("Первое и второе числа равны и являются максимальными: " + num1);
            }
        if (num1 < num3)
            {
                Console.WriteLine("Третье число максимальное: " + num3);
            }
    }
if (num1 == num3)
    {
        if (num1 > num2)
            {
                 Console.WriteLine("Первое и третье числа равны и являются максимальными: " + num1);
            }
        if (num1 < num2)
            {
                Console.WriteLine("Второе число максимальное: " + num2);
            }
    }
if (num3 == num2)
    {
        if (num1 > num3)
            {
                Console.WriteLine("Первое число максимальное: " + num1);
            }
        if (num1 < num3)
            {
                Console.WriteLine("Второе и третье число равны и являются максимальными: " + num3);
            }
    }
else if (num1 > num2 && num1 > num3)
    {
        Console.WriteLine("Максимальное число: " + num1);
    }
else if (num2 > num1 && num2 > num3)
    {
        Console.WriteLine("Максимальное число: " + num2);
    }
else if (num3 > num1 && num3 > num2)
    {
        Console.WriteLine("Максимальное число: " + num3);
    }


