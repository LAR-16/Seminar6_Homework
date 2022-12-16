
Console.Clear();
Console.WriteLine("Введите переменную k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите переменную b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = (b2-b1)/(k1-k2);

double y = k1 * x + b1;
Console.WriteLine($"Координаты точки пересечения -> ({x};{y})");