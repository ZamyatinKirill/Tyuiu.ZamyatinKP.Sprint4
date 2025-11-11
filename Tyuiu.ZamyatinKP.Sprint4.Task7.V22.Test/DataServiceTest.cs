using Tyuiu.ZamyatinKP.Sprint4.Task7.V22.Lib;

namespace Tyuiu.ZamyatinKP.Sprint4.Task7.V22.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            string value = "695324951753684";
            int res = ds.Calculate(n, m, value);
            Assert.Equal(9216, res);
        }
    }
}