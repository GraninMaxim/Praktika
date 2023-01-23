using System.Data;
using System.Net.WebSockets;

namespace library
{
    public class Class1
    {
        public int FindFirst(int value)
        {
            int num = value / 100;
            if (num % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int GetSum(int value1, int value2, int value3)
        {
            int i = 0;
            if (value1 % 3 == 0)
            {
                i += value1;
            }
            if (value2 % 3 == 0)
            {
                i += value2;
            }
            if (value3 % 3 == 0)
            {
                i += value3;
            }
            return i;
        }

        public static int[] GetMas(int[] massive)
        {

            for (int i = 0; i < massive.Length; i++)

                if (massive[i] < 0)
                    massive[i] = Math.Abs(massive[i]);
            return massive;
        }


        public static int FindNum(int[,] massive)
        {
            int[] mas = new int[massive.GetLength(1)];
            int unswer = 0;
            for(int i = 0; i < massive.GetLength(1); i++)
            {
                int proizv = 1;
                for(int j= 0; j < massive.GetLength(0); j++)
                {
                    proizv *= massive[j, i];
                }
                mas[i] = proizv;
            }

            int max = mas[0];
            for(int i = 0; i < massive.GetLength(1); i++)
            {
                if(mas[i] > max)
                {
                    max = mas[i];
                    unswer = i;
                }
            }
            return unswer + 1;
           
        }

    }
    public static class VisualArray
    {
        //Метод для одномерного массива
        public static DataTable ToDataTable<T>(this T[] arr)
        {
            var res = new DataTable();
            for (int i = 0; i < arr.Length; i++)
            {
                res.Columns.Add("col" + (i + 1), typeof(T));
            }
            var row = res.NewRow();
            for (int i = 0; i < arr.Length; i++)
            {
                row[i] = arr[i];
            }
            res.Rows.Add(row);
            return res;
        }
        //Метод для двухмерного массива
        public static DataTable ToDataTable<T>(this T[,] matrix)
        {
            var res = new DataTable();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add("col" + (i + 1), typeof(T));
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }

                res.Rows.Add(row);
            }

            return res;
        }

    }
}