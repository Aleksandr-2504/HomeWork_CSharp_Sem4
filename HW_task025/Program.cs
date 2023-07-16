/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
             и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double NatDegree(double arg1, int arg2)
{
  double result = 1;
  int count = 1;
  //for (int count = 1, count <= arg2; count++)
  while (count > 0 && count <= arg2)
  {
    result *= arg1;
    count++;
  }
  return result;
}

/*int IfArg(int arg)
{
  if (arg <= 0)
  {
    Console.Write("!!!Введите целое положительное число B: ");
    arg = int.Parse(Console.ReadLine());
  }
  return arg;
} */

Console.Clear();
Console.Write("Введите число А: ");
double digA = double.Parse(Console.ReadLine());

Console.Write("Введите натуральное число В: ");
int digB = int.Parse(Console.ReadLine());
//IfArg(digB);
if (digB <= 0)
{
  Console.Write("!!!Введите целое положительное число B: ");
  digB = int.Parse(Console.ReadLine());
}
Console.Write($"Число A={digA} в степени B={digB} равно: {NatDegree(digA, digB):f2}");
