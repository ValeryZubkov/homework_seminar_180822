// Задан номер года, найдите наименьший номер года,
 //который строго больше заданного и в котором все цифры различны.
Console.WriteLine("Введите год: ");
string year = Console.ReadLine();
int yearCount = Convert.ToInt32(year) + 1; //Начинаем проверку со следующего года от заданного.
bool k =false;
for(int i = yearCount; i <= 9000; i++) //Воспользуемся заданными границами возможных годов (1000 ≤ y ≤ 9000) из условия задачи
{
    if(year[1] == year[0])  yearCount = i; k = true;
    if(year[2] == year[0])  yearCount = i; k = true;
    if(year[3] == year[0])  yearCount = i; k = true;
    if(year[2] == year[1])  yearCount = i; k = true;
    if(year[3] == year[1])  yearCount = i; k = true;
    if(year[3] == year[2])  yearCount = i; k = true;
    if(k == false) break; 
    else year = Convert.ToString(yearCount);  
}
Console.WriteLine($"{yearCount}");