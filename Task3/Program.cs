// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int N = Convert.ToInt32(Console.ReadLine());
double count  = 1;
while(count<=N)
{
    Console.WriteLine(Math.Pow(count,3));
    count++;
}