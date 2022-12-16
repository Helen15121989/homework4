//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11


Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());
int sum = GetSumDigits (number);
Console.WriteLine("Сумма цифр: " + sum);

int GetSumDigits (int number)

{
    int sum = 0;

    while (number > 0)
    {

        sum = (sum + (number % 10));
        number = number /10;
    }
    return sum;
    

}

