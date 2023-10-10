Console.WriteLine("Введите коэффициент а");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент c");
double c = Convert.ToDouble(Console.ReadLine());
//Формула абсциссы
double x =-b*2*a;
//Формула ординаты
double y = a * (x * x) + b * x + c;
Console.WriteLine($"Абсцисса (x) ={x}");
Console.WriteLine($"Ордината (y) ={y}");