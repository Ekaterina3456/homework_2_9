// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summ(int num1, int num2)
{
    int result = 0;
    while (true)
    {
        if (num1 > num2)
            break;
        result += num1;
        num1++;
    }
    return result;
}




Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма чисел от {num1} до {num2} равна: {Summ(num1,num2)}");