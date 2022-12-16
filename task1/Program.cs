//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
//3, 5 -> 243 (3⁵)


Console.WriteLine("Введите два числа");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
GetExponentiation (a,b);


void GetExponentiation (int a, int b)
{
   int result = a;


   for (int i = 1; i < b; i++)
   
   {
    result = result * a;
    
   }
Console.WriteLine (result);
   
   }



