// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите размер массива ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [number];
FillArray(array);
//PrintArray(array);

void FillArray(int[] array)
{
    for(int i = 0; i < number; i++)
    {
    Console.Write($"Число {i+1} = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] array)
{
int Numbers = 0;
{
    for(int i = 0; i < array.Length; i++)
    {
    if(array[i] > 0 ) Numbers +=1;
    {
    return; 
    }     
    }
}
Console.WriteLine($"Количество чисел больше нуля = {Numbers}");
}

