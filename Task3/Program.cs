/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/
double [] CreatArrey ()
{
    Console.WriteLine ("Input size of arrey: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double [] newArrey = new double [size];
    for (int i = 0; i < size; i++)
    {
        newArrey[i] = new Random().NextDouble() * 100;
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
    double max = elemMax[0];
    for (int i = 1; i < elemMax.Length; i++)
    {
        if (elemMax[i] > max)
        max = elemMax[i];
        else max = elemMax[0];
    }
    Console.WriteLine ($"Maximum: {max}");
    return max;
}
double MinElem (double [] elemMin)
{
    double min = elemMin[0];
    for (int i = 1; i < elemMin.Length; i++)
    {
        if (elemMin[i] < min)
        min = elemMin[i];
        else
        min = elemMin[0];
    }
    Console.WriteLine ($"Minimum: {min}");
    return min;
}


double [] finArrey = CreatArrey();
ShowArrey (finArrey);
double maxx = MaxElem (finArrey);
double minn = MinElem (finArrey);
double diff = maxx - minn;
 Console.WriteLine ($"difference between maximum and minimum is: {diff}");
