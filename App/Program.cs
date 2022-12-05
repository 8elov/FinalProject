// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество значений для проверки: ");
int size = Convert.ToInt32(Console.ReadLine());

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
        Console.WriteLine();
    }
}

string[] inputArray = new string[size];

for(int i = 0; i < inputArray.Length; i++)
{
    Console.WriteLine("Введите " + (i + 1) + " значение:");
    inputArray[i] =  Console.ReadLine()!;

    if (inputArray[i] == null)
    {
        inputArray[i] = "";
    }
}

int count = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        count++;
    }
}

string[] outputArray = new string[count];

for (int i = 0; i < outputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        outputArray[i] = inputArray[i];
    }
}

Console.WriteLine("Даны строки: ");
PrintArray(inputArray);
Console.WriteLine("Строки, длина которых меньше либо равна 3 символа:");
PrintArray(outputArray);