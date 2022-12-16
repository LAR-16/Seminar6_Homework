
Console.Clear();
Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x3: ");
int x3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y3: ");
int y3 = int.Parse(Console.ReadLine());

double A = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
double B = Math.Sqrt(Math.Pow((x3-x2), 2) + Math.Pow((y3-y2), 2));
double C = Math.Sqrt(Math.Pow((x1-x3), 2) + Math.Pow((y1-y3), 2));
double p = (A + B + C) / 2;
double S = Math.Round(Math.Sqrt(p*(p-A)*(p-B)*(p-C)), 2);
Console.WriteLine($"Площадь треугольника = {S}");
