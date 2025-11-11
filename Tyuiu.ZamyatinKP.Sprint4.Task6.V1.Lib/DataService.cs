using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZamyatinKP.Sprint4.Task6.V1.Lib
{
    public class DataService : ISprint4Task6V1
    {
        public int Calculate(string[] array)
        {
            int res = 0;
            foreach (string s in array)
            {
                if (s.Length > 6)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
