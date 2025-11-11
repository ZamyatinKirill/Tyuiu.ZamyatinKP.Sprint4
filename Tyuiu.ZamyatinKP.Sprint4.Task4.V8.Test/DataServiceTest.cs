using Tyuiu.ZamyatinKP.Sprint4.Task4.V8.Lib;

namespace Tyuiu.ZamyatinKP.Sprint4.Task4.V8.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int[,] array = { { 1, 3, 2, 2, 5 },{ 6, 1, 5, 5, 2 },{ 1, 5, 4, 1, 4 },{ 4, 1, 4, 4, 5 },{ 4, 6, 1, 1, 4 } };
            int[,] res = ds.Calculate(array);
            int[,] wait = { { 1, 3, 1, 1, 5 }, { 1, 1, 5, 5, 1 }, { 1, 5, 1, 1, 1 }, { 1, 1, 1, 1, 5 }, { 1, 1, 1, 1, 1 } };
            Assert.Equal(wait, res);
        }
    }
}