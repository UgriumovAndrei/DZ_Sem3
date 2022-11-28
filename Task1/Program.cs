//  Ввод пятизначное число, определить является ли оно палиндромом
int N = Convert.ToInt32(Console.ReadLine());
if(N % 10 == N / 10000  &&  (N/10) % 10 == (N / 1000) % 10)
    Console.Write("DA");
else
    Console.Write("NET");