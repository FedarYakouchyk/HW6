/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

void printArray(int[] array)
{
    System.Console.WriteLine("[ " + String.Join(", ", array) + " ]");
}
void Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    System.Console.WriteLine($"Количество чисел больше ноля = {count}");
}
int[] NewArr()
{
    System.Console.WriteLine("Введите размер массива.");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    if (size > 0)
    {
        System.Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        printArray(array);
    }
    else
    {
        System.Console.WriteLine("Введённое вам значение не корректно, попробуйте снова!");

    }
    return array;
}
int[] ARR = NewArr();
Count(ARR);
