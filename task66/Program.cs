// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите первое значение: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите второй значение: ");
int N = int.Parse(Console.ReadLine());

int Sum = 0;
void Rec(int sum,int m, int n)
{
    if (n+1==m)
    {
        Console.Write(sum);
        return;
    }
    Rec(sum+=n,m,n-1);   
}    

Rec(Sum,M,N);

