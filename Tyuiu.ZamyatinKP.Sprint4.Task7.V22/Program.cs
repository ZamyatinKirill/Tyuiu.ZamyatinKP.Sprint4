using Tyuiu.ZamyatinKP.Sprint4.Task7.V22.Lib;

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
        int n = 5;
        int m = 3;
        string value = "695324951753684";
        int res = ds.Calculate(n, m, value);
        Console.WriteLine(res);
    }
}