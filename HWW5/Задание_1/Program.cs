// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Здравствуйте, эта программа посчитает сколько чисел больше 0 ввели.");
Console.WriteLine("Сколько чисел хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());
int[] numArray = new int[size];
int[] FillArray(int[] arr)
{
    int length = arr.Length;
    int i = 0;
    int q = 0;
    while (i < length)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return arr;
}
int GetResult(int[] arr1)
{
    int length = arr1.Length;
    int i = 0;
    int count = 0;
    while (i < length)
    {
        if (arr1[i] > 0) count++;
        i++;
    }
    return count;
}
FillArray(numArray);
Console.WriteLine(String.Join(", ", numArray));
Console.WriteLine("Кол-во чисел больше 0 будет = " + GetResult(numArray));
