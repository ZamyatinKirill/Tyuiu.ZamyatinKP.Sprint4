using Tyuiu.ZamyatinKP.Sprint4.Task0.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int res = ds.GetMultEvenArrEl(array);
        Console.WriteLine(res);
    }
}