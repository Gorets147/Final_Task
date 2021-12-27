/*Написать программу, которая из имеющегося массива целых чисел формирует
массив из четных чисел.Первоначальный массив можно ввести с клавиатуры,
либо сгенерировать случайным образом. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.*/


int[] numbers = new int[] { 1, 5, 6, 8, 9 };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}
PrintArray(numbers);

int FindEven(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
    }
}
