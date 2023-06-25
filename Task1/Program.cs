/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
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
    for (int i = 0; i < elemSum.Length; i++)
        if (elemSum[i] % 10 == 0)
        sum++;
    Console.Write ($"number of even elements: {sum}");
    return sum;
}

Console.WriteLine ("Input size of arrey: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int minArrVal = 100;
int maxArrVal = 1000;
int [] finArrey = CreatArrey(sizeArr, minArrVal, maxArrVal);
ShowArrey (finArrey);
int finSum = SumElem (finArrey);

