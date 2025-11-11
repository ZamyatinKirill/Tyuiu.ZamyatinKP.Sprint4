using Tyuiu.ZamyatinKP.Sprint4.Task2.V7.Lib;


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

        int[] array = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            array[i] = rnd.Next(4, 9);
        }

        Console.WriteLine("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine(array[i] + "\t");
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int res = ds.Calculate(array);
        Console.WriteLine(res);
    }
}