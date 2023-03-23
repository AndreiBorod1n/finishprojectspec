Console.Write("Первоначальный массив: ");
string[] array = { "hel", "privet", "2312", "pr", "hey" };
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine(" ");
void ArrayThreeNum(string[] matr)
{
    string[] newArray = new string[3];
    for (int i = 0; i < matr.Length; i++)
    {
        int l = 0;
        if (matr[i].Length <= 3)
        {
            newArray[l] = matr[i];
            Console.Write($"{newArray[l]} ");
            l++;
        }
    }
}
Console.WriteLine("Новый массив из строк старого массива, в которых число символов не превышает 3: ");
ArrayThreeNum(array);