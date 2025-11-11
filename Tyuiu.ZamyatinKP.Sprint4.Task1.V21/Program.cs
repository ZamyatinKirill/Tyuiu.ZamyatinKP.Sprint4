using Tyuiu.ZamyatinKP.Sprint4.Task1.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.WriteLine("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[len];

        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("Введите значение " + i + " элемента массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int res = ds.Calculate(array);
        Console.WriteLine(res);
    }
}