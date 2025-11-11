using Tyuiu.ZamyatinKP.Sprint4.Task0.V8.Lib;

namespace Tyuiu.ZamyatinKP.Sprint4.Task0.V8.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int res = ds.GetMultEvenArrEl(array);
            Assert.Equal(384, res);
        }
    }
}