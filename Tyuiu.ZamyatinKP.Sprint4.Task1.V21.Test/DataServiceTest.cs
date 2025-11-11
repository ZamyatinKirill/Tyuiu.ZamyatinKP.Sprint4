using Tyuiu.ZamyatinKP.Sprint4.Task1.V21.Lib;

namespace Tyuiu.ZamyatinKP.Sprint4.Task1.V21.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int[] array = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };
            int res = ds.Calculate(array);
            Assert.Equal(1769472, res);
        }
    }
}