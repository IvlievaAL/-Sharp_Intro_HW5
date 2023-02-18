/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
System.Console.WriteLine("Enter massive lenght: "); // Хочу, чтобы размер массива задал пользователь.
int size = Int32.Parse(System.Console.ReadLine());
int []OursArray= MassiveOfRandomNumbers(size);
MassiveAsString (OursArray); 
System.Console.WriteLine(ToCountEvenNumbersInMassive(OursArray));

int[] MassiveOfRandomNumbers(int size)
{
 int [] ArrayOfNumbers= new int [size];
 Random rand=new Random();
 for (int index=0; index<size; index++)
 {
    ArrayOfNumbers[index]=rand.Next();
 }
 return ArrayOfNumbers;
}

void MassiveAsString (int [] OursArray)
{
    string ArrayAsString = string.Join(" , ", OursArray); 
    System.Console.WriteLine(ArrayAsString);
}