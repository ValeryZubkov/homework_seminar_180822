// Слоник решил сходить в гости к другу. 
//Оказалось, что дом слоника находится в точке 0, а дом его друга в точке x(x > 0) координатной прямой. За один шаг слоник может переместиться на 1, 2, 3, 4 или 5 позиций вперёд. 
//Помогите ему определить, за какое минимальное количество шагов он может добраться до дома друга.
Console.WriteLine("Введите координату дома друга слоника: ");
int x = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
for(int i = 5; i > 0; i--) //начинаем с наибольшего шага слоника, который равен 5 и далее просчитываем, уменьшая на единицу до значения 1. 
{
    count = count + x/i;   //прибавляем шаги, если расстояние(в дальнейшем, - остаток от деления) делится нацело на величину шага "i".
    if(x%i == 0) break;    //если расстояние поделилось нацело, выходим из цикла.
    x=x%i;                 //если нет, то запоминаем остаток от деления для дальнейших расчетов. 
}
Console.WriteLine($"Минимальное количество шагов до дома друга: {count}");
