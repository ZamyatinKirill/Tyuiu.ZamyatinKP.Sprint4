using Tyuiu.ZamyatinKP.Sprint4.Task3.V3.Lib;

namespace Tyuiu.ZamyatinKP.Sprint4.Task3.V3.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int[,] array = { { 9, 4, 5, 4, 8 },{ 7, 6, 7, 7, 4 },{ 4, 4, 3, 5, 6 },{ 6, 5, 9, 4, 9 },{ 9, 7, 8, 7, 7 } };
            int res = ds.Calculate(array);
            Assert.Equal(14, res);
        }
    }
}