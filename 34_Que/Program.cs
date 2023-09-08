/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int InputNun(string message){
    
Console.WriteLine(message);
return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size){
    return new int[size];
}

void FillArray(int[] arr, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i<arr.Length; i++)
        arr[i]=rnd.Next(minValue,maxValue + 1);
}





 void PrintArray(int[] arr)
 {
     for(int i = 0; i < arr.Length; i++)
     {
         Console.Write(arr[i] + " ");
     }
     Console.WriteLine();
 }

 void PrintArrayTwo(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        int count = 0;
        if (arr[i] % 2 == 0)
        Console.Write(arr[i]+" ");
        
       count++;
    }
  
}



int size = InputNun("Введите размер массива: ");
int min = InputNun("Введите минимальное значение массива: ");
int max = InputNun("Введите максимальное значение массива: ");

int[] myArray = CreateArray(size);
FillArray(myArray, min, max);
PrintArray(myArray);
PrintArrayTwo(myArray);
