using Tyuiu.ZamyatinKP.Sprint4.Task4.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[len, len];

        for (int i = 0; i <= len - 1; i++)
        {
            for (int j = 0; j <= len - 1; j++)
            {
                Console.WriteLine("Введите значение " + i + ", " + j + " элемента массива: ");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int[,] res = ds.Calculate(array);
        Console.WriteLine(res);
    }
}