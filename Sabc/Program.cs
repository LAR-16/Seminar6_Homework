
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

double AB = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
double BC = Math.Sqrt(Math.Pow((x3-x2), 2) + Math.Pow((y3-y2), 2));
double CA = Math.Sqrt(Math.Pow((x1-x3), 2) + Math.Pow((y1-y3), 2));
double p = (AB + BC + CA) / 2;
double S = Math.Round(Math.Sqrt(p*(p-AB)*(p-BC)*(p-CA)), 2);
Console.WriteLine($"Площадь треугольника = {S}");
