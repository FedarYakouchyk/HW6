/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

void printArray(double[] array)
{
    System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}
double[] NewArr()
{
    double[] array = new double[2];
    System.Console.WriteLine("Введите координаты b и k");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
double[] RezArr(double [] arr1, double [] arr2)
{
    /* y = arr1[0] * x + arr[1], y = arr2[0] * x + arr2[1]
arr1[0]*x + arr1[1] = arr2[0]*x + arr2[1]
arr1[0]*x - arr2[0]*x = arr2[1]- arr1[1] );

x = (arr2[1]- arr1[1])/(arr1[0] - arr2[0])
y = arr1[0] * (arr2[1]- arr1[1])/(arr1[0] - arr2[0]) + arr1[1] */

    double[] Rez = new double[2];

    Rez[0] = (arr2[0] - arr1[0]) / (arr1[1] - arr2[1]);
    Rez[1] = arr1[1] * ((arr2[0] - arr1[0]) / (arr1[1] - arr2[1])) + arr1[0];

    return Rez;
}

double[] arr1 = NewArr();
double[] arr2 = NewArr();
double [] Rez = RezArr(arr1, arr2);
printArray (arr1);
printArray(arr2);
printArray(Rez);

