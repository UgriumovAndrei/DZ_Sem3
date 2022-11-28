// расстояние в 3д пространстве
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double xb = Convert.ToDouble(Console.ReadLine());
double xa = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
double zb = Convert.ToDouble(Console.ReadLine());
double za = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
Console.WriteLine(Math.Round(result, 2));
