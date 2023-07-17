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

void PrintArr(int[] d)//??здесь возник вопрос: метод вывода массива на печать не получился
{
  int count = d.Length;
  int pos = 0;
  //1 способ:
  /*while (pos < count - 1)
  {
    Console.Write($"{d[pos]}, ");
    pos++;
  }
  Console.Write($"{d[count - 1]}");*/
  //2 способ: 
  Console.Write($"{String.Join(", ", d)}");//2 способ
  Console.Write(" -> [");
  //pos = 0;//эта переменная здесь нужна при 1 способе
  while (pos < count - 1)
  {
    Console.Write($"{d[pos]}, ");
    pos++;
  }
  Console.Write($"{d[count - 1]}");
  Console.Write("]");
}

Console.Clear();
int[] arr = new int[8];
RandomArr(arr);
PrintArr(arr); //??здесь возник вопрос: почему не проходит метод??..!!УРА разобрался!!
/*Console.Write($"{String.Join(", ", arr)} -> [{String.Join(", ", arr)}]");*/
//если не используется метод PrintArr, тогда используют строку выше
