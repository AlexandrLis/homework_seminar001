//Задание 4

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (num > 0)
while (count < num)
{
    if (count%2 == 0)
        {
            Console.WriteLine(count);
        }
count += 1;
}

