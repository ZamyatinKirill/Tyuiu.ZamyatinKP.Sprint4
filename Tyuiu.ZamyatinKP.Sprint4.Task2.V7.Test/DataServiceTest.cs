using Tyuiu.ZamyatinKP.Sprint4.Task2.V7.Lib;

namespace Tyuiu.ZamyatinKP.Sprint4.Task2.V7.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3 };
            int res = ds.Calculate(array);
            Assert.Equal(2, res);
        }
    }
}