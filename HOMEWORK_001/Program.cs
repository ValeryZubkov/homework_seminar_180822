//Театральная площадь в столице Берляндии представляет собой прямоугольник n × m метров.
//По случаю очередного юбилея города, было принято решение о замощении площади квадратными гранитными плитами.
//Каждая плита имеет размер a × a.
//Какое наименьшее количество плит понадобится для замощения площади?
Console.WriteLine("Задайте размер стороны n Театральной площади: ");
long n = long.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте размер стороны m Театральной площади: ");
long m = long.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте размер стороны квадратной гранитной плиты a: ");
long a = long.Parse(Console.ReadLine() ?? "0");
long aform = a;
long aforn = a;
int i = 1;
int j = 1;
while(aforn < n)
{
    aforn = aforn + a;
    i = i + 1;
}
while(aform < m)
{
    aform = aform + a;
    j = j + 1;
}
Console.WriteLine($"Для замощения Театральной площади понадобится {i*j} плит(ы).");

