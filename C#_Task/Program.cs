/*Написать программу, которая из имеющегося массива целых чисел формирует
массив из четных чисел.Первоначальный массив можно ввести с клавиатуры,
либо сгенерировать случайным образом. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.*/


int[] numbers = new int[] { 2, 3, 5, 3, 8, 4,10,12 };
int[] EvenArray = new int[1];

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}
int[] FindEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
        else
        {
            System.Console.WriteLine($"Число {array[i]} - не чётное");
        }
    }
    System.Console.WriteLine(count + "- Кол-во чётных чисел");
    EvenArray = new int[count];
    int j = 0;
    int t = 0;
    while (j < EvenArray.Length)
    {
        if (array[t] % 2 == 0)
        {
            EvenArray[j] = array[t];
            j++;
        }
        t++;
    }
    return EvenArray;
}

PrintArray(EvenArray);
FindEven(numbers);
PrintArray(EvenArray);
