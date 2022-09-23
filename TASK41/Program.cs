/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int n = Prompt("Введите число элементов массива ");


int[] array = new int[n];
FillArray(array);
PrintArray(array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}

void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число ");
    array[i] = Int32.Parse(Console.ReadLine());
}
}
void PrintArray(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        count++;
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("   больше нуля  " + count);
}