/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/
int [] CreatArrey (int size, int minVal, int maxVal)
{
    int [] newArrey = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArrey[i] = new Random().Next(minVal, maxVal + 1);
    }
    return newArrey;
}
void ShowArrey (int [] arreyToShow)
{
    for (int i = 0; i < arreyToShow.Length; i++)
    Console.Write (arreyToShow[i] + " ");
    Console.WriteLine();
}
int SumElem (int [] elemSum)
{
    int sum = 0;
    for (int i = 1; i < elemSum.Length; i=i+2)
    sum = sum + elemSum[i];
    Console.Write ($"sum of odd elements: {sum}");
    return sum;
}
Console.WriteLine ("Input size of arrey: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int minArrVal = -1000;
int maxArrVal = 1000;
int [] finArrey = CreatArrey(sizeArr, minArrVal, maxArrVal);
ShowArrey (finArrey);
int finSum = SumElem (finArrey);