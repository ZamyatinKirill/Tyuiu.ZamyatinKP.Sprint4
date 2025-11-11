using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZamyatinKP.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 1;
            int[,] matrix = new int[n, m];

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                    if (matrix[i, j] % 2 == 0)
                    {
                        res *= matrix[i, j];
                    }
                }
            }
            return res;
        }
    }
}
