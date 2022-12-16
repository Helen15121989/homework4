//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]



int []myArray = new int [8];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write("Введите элемент массива: ");
    myArray[i] = int.Parse(Console.ReadLine());
}


for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine (myArray[i]);
}

