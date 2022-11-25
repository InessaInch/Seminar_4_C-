/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/
Console.Write("введите число A:  ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B:  ");
int NumberB = Convert.ToInt32(Console.ReadLine());
int GetDegreeNumber(int NumberA, int NumberB)
{
  int result = 1;
  for(int i = 0; i < NumberB; i++)
  {
    result = result * NumberA;
  }
  return result;
}
int DegreeNumber = GetDegreeNumber(NumberA,NumberB);
Console.WriteLine("A в степени B равно: " + DegreeNumber);
