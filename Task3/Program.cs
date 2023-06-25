/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/
double [] CreatArrey ()
{
    double [] newArrey = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArrey[i] = new Random().NextDouble();
    }
    return newArrey;
}
void ShowArrey (double [] arreyToShow)
{
    for (int i = 0; i < arreyToShow.Length; i++)
    Console.Write (arreyToShow[i] + " ");
    Console.WriteLine();
}
double MaxElem (double [] elemMax)
{
    double max = 0;
    for (int i = 1; i < elemMax.Length; i++)
        if (elemMax[i] > max)
        max = elemMax[i];
    Console.Write ($"Maximum: {max}");
    return max;
}
double MinElem (double [] elemMin)
{
    double min = 0;
    for (int i = 1; i < elemMin.Length; i++)
        if (elemMin[i] > min)
        min = elemMin[i];
    Console.Write ($"Minimum: {min}");
    return min;
}

Console.WriteLine ("Input size of arrey: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
double [] finArrey = CreatArrey();
ShowArrey (finArrey);
MaxElem (finArrey);
MinElem (finArrey);
double diff = MaxElem (finArrey) - MinElem (finArrey);
 Console.Write ($"difference between maximum and minimum is: {diff}");
