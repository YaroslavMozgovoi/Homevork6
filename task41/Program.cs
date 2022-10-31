// Задача 41:
//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Cколько цифр вы хотите ввести");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-ое числo");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}


void PrintArray(int[] array)
{
     Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine(")");
}

int CollPositivNumber(int[] array, int size)
{
    int numb = 0; 
    for (int i = 0; i < size; i++)
    {
        if (array[i]>0) numb = numb+1;
    }
    return numb;
}

PrintArray(arr);
int collPositivNumber = CollPositivNumber(arr,size);
Console.WriteLine($"Количество чисел больше нуля = {collPositivNumber}");