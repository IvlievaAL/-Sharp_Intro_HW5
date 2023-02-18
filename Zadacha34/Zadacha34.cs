/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
System.Console.WriteLine("Enter massive lenght: "); // Хочу, чтобы размер массива задал пользователь.
int size = Int32.Parse(System.Console.ReadLine());
int []OursArray= MassiveOf3DigitsPositiveRandomNumbers(size);
MassiveAsString (OursArray); // Выведи массив в консоль.

int[] MassiveOf3DigitsPositiveRandomNumbers(int size)
{
 int [] ArrayOfNumbers= new int [size];
 Random rand=new Random();
 for (int index=0; index<size; index++)
 {
    ArrayOfNumbers[index]=rand.Next(100,1000);
 }
 return ArrayOfNumbers;
}

void MassiveAsString (int [] OursArray)
{
    string ArrayAsString = string.Join(" , ", OursArray); 
    System.Console.WriteLine(ArrayAsString);
}