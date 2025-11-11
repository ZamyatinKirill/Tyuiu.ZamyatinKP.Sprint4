using Tyuiu.ZamyatinKP.Sprint4.Task5.V17.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
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
                array[i, j] = rnd.Next(-9, 4);
            }
        }

        Console.WriteLine("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            for (int j = 0; j <= len - 1; j++)
            {
                Console.WriteLine(array[i, j] + "\t");
            }
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int res = ds.Calculate(array);
        Console.WriteLine(res);
    }
}