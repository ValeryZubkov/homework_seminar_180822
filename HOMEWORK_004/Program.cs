// Почти счастливое число (4, 7)
int Digitsnumber(int numb)   // функция подсчета количества цифр в числе
{
int digitNumber = 1;
while(numb / 10 >= 1 || numb / 10 <= -1)
{
    numb = numb / 10;
    digitNumber = digitNumber + 1;
}
return digitNumber;
}

int Digitindex(int number, int index) // функция нахождения любой цифры числа
{
int digitIndex = 0;
int parametr = 1;        
int count = 0;
while(count < (Digitsnumber(number) - index)) 
      {
      parametr = parametr * 10;  
      count++;
      }
if(number > 0)                  
   {
    digitIndex = number / parametr % 10;
   }
    else
   {
    digitIndex = -number / parametr % 10;
   } 

return digitIndex;
}

Console.WriteLine("Введите число для проверки: ");
int n = int.Parse(Console.ReadLine() ?? "0");
bool k = false; 
for(int i=0; i < Digitsnumber(n); i++)
{    
    if((Digitindex(n,i+1) == 4 || Digitindex(n,i+1) == 7)
        &&(Digitsnumber(n) == 4 || Digitsnumber(n) == 7))
        k = true;
}
if(k == true)
{
    Console.WriteLine("Да, введенное Вами число является счастливым.");
}
else
{
    Console.WriteLine("Нет, введенное Вами число не является счастливым.");
}