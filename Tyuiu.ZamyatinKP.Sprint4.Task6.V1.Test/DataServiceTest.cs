using Tyuiu.ZamyatinKP.Sprint4.Task6.V1.Lib;

namespace Tyuiu.ZamyatinKP.Sprint4.Task6.V1.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            string[] array = { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(array);
            Assert.Equal(2, res);
        }
    }
}