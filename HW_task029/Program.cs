/*
Задача 29: Напишите программу, которая задаёт массив 
           из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void RandomArr(int[] array)//метод заполнения массива случайными значениями от 0 до 99
{
  int length = array.Length;
  int index = 0;
  while (index < length)
  {
    array[index] = new Random().Next(0, 100);
    index++;
  }
}

/*void PrintArr(int[] d)//??здесь возник вопрос: метод вывода массива на печать не получился
{
  int count = d.Length;
  int pos = 0;
  while (pos < count)
  {
    //Console.WriteLine(d[pos]);
    Console.Write($"{String.Join(", ", d[pos])}");
    pos++;
  }
  //return d;
} */

Console.Clear();
int[] arr = new int[8];
RandomArr(arr);
Console.Write($"{String.Join(", ", arr)} -> [{String.Join(", ", arr)}]");
//PrintArr(arr); //??здесь возник вопрос: почему не проходит метод??
