using Tyuiu.ZamyatinKP.Sprint4.Task5.V17.Lib;

namespace Tyuiu.ZamyatinKP.Sprint4.Task5.V17.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int[,] array = { { 1, 3, 2, 2, 5 }, { 6, 1, 5, 5, 2 }, { 1, 5, 4, 1, 4 }, { 4, 1, 4, 4, 5 }, { 4, 6, 1, 1, 4 } };
            int res = ds.Calculate(array);
            Assert.Equal(0, res);
        }
    }
}