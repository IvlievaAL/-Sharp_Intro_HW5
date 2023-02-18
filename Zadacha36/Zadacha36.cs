/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
System.Console.WriteLine("Enter massive lenght: "); // Хочу, чтобы размер массива задал пользователь.
int size = Int32.Parse(System.Console.ReadLine());
int []OursArray= MassiveOfRandomNumbers(size);
/*MassiveAsString (OursArray); // Вывод массива в консоль не удален 
для удобства проверки дз, хотя по тз выводить сам массив не нужно*/
System.Console.WriteLine(ToCountSumOfNumbersInUnevenPositions(OursArray));

int[] MassiveOfRandomNumbers(int size)
{
 int [] ArrayOfNumbers= new int [size];
 Random rand=new Random();
 for (int index=0; index<size; index++)
 {
    ArrayOfNumbers[index]=rand.Next(-99,100); // Пусть в массиве лежат только одно- и двузначные числа.
 }
 return ArrayOfNumbers;
}

/*void MassiveAsString (int [] OursArray)
{
    string ArrayAsString = string.Join(" , ", OursArray); 
    System.Console.WriteLine(ArrayAsString);
}*/

int ToCountSumOfNumbersInUnevenPositions (int [] OursArray)
{
 int SumOfNumbersInUnevenPositions=0;
    for (int index=1; index<OursArray.Length; index=index+2) // Судя по примеру в тз, первой нечетной позицией считать надо ячейку под индексом 1.
    {
     SumOfNumbersInUnevenPositions=SumOfNumbersInUnevenPositions+OursArray[index];
     System.Console.WriteLine(OursArray[index]);
    }
    return SumOfNumbersInUnevenPositions;
}