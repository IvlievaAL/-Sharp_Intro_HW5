﻿/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
System.Console.WriteLine("Enter massive lenght: "); // Хочу, чтобы размер массива задал пользователь.
int size = Int32.Parse(System.Console.ReadLine());
double []OursArray= MassiveOfRandomNumbers(size);
MassiveAsString (OursArray); /* Вывод массива в консоль не удален 
для удобства проверки дз, хотя по тз выводить сам массив не нужно*/

double[] MassiveOfRandomNumbers(int size)
{
 double [] ArrayOfNumbers= new double [size];
 Random rand=new Random();
 for (int index=0; index<size; index++)
 {
    ArrayOfNumbers[index]=rand.NextDouble()*20;
 }
 return ArrayOfNumbers;
}

void MassiveAsString (double [] OursArray)
{
    string ArrayAsString = string.Join(" , ", OursArray); 
    System.Console.WriteLine(ArrayAsString);
}