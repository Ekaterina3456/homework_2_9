// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

static int Akkerman (int n, int m)
{
    if (n==0) return m+1;
    else if (n!=0 && m ==0) return Akkerman(n-1,1);
    else if (n>0 && m>0) return Akkerman(n-1,Akkerman(n,m-1));
return Akkerman(n,m);
}



Console.WriteLine("введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"результат работы функции: {Akkerman(n,m)}");