//Солдат и бананы
Console.WriteLine("Задайте стоимость первого банана k: ");
int k = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте количество денег у солдата n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте желаемое количество бананов w: ");
int w = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
for(int i = 1; i <= w; i++)
{
  sum = sum + k * i;
}
if(sum > n)
{
    Console.WriteLine($"Солдату не хватает {sum - n} долларов.");
}
else
{
    Console.WriteLine($"У солдата достаточно денег для покупки {w} бананов.");
}