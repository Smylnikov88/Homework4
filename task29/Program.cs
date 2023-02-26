// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[]collection)
{
    int lenth = collection.Length;
    int index = 0;
    while ( index< lenth)
    {
        collection[index] = new Random().Next(0,9);
        index++;
    }
}

 void PrintArray(int[]col)
 {
 int count = col.Length;
 int position = 0;
 while ( position < count)
 {
    Console.Write(col[position]);     position++;
 }
 }
int[] arr = new int[9];
 FillArray(arr);
 Console.WriteLine();
 PrintArray(arr);

