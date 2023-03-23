string[] array = {"hello", "privet", "231", "pr", "hey"};
void ArrayThreeNum(string[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        if(matr[i].Length <= 3)
        {
            Console.Write($"{matr[i]} ");
        }
    }
}
Console.WriteLine("Строки, число символов в которых равно или менее трёх: ");
ArrayThreeNum(array);