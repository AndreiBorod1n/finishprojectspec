int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
void FillArray(string[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        matr[i] = Console.ReadLine();
    }
}
FillArray(array);
void ArrayThreeNum(string[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        if(matr[i].Length <= 3)
        {
            Console.WriteLine(matr[i]);
        }
    }
}
ArrayThreeNum(array);