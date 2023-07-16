/*Задача 27: Напишите программу, которая принимает на вход число и 
             выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumNum(int arg)
{
  if (arg < 0) arg = arg * (-1);
  int count = 10;
  int result = arg % 10;
  int num = arg;
  while (num != 0)
  {
    result += (arg / count) % 10; //...num = (arg / count) % 10 ;
    count *= 10;
    num = arg / count;
  }
  return result;
}

Console.Clear();
Console.Write("Введите число А: ");
int numA = int.Parse(Console.ReadLine());
SumNum(numA);
Console.Write($"Сумма цифр в числе numA={numA} равна: {SumNum(numA)}");
