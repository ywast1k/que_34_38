//   Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//   [3, 7, 23, 12] -> 19
//   [-4, -6, 89, 6] -> 0

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
    {
        arr[i]=rnd.Next(minValue,maxValue + 1);
        Console.Write(arr[i] + " ");}
}

int SummaElements(int[] arr){

int sumEl = 0;
for (int i = 0; i <arr.Length; i++ ){
             if (i % 2 != 1)
            {
        sumEl = sumEl + arr[i];
            }
         {
         return sumEl;
         }
  }
}


int size = InputNun("Введите размер массива: ");
int min = InputNun("Введите минимальное значение массива: ");
int max = InputNun("Введите максимальное значение массива: ");
int[] myArray = CreateArray(size);
FillArray(myArray, min, max);
SummaElements(myArray);
int sumEl =SummaElements(myArray);

Console.Write("сумма: " + sumEl );



