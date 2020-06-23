using System;
// Шитов Евгений 

//  Решить задачу о нахождении длины максимальной последовательности

namespace Algorithms_Lesson4
{
    static class Solution1
    {
        static int Met(int i, int j, int[,] z, int[] masA, int[] masB)
        {
            if (z[i, j] != -1) return z[i, j];

            if (i == 0 || j == 0)
                z[i, j] = 0;
            else
            {
                if (masA[i] == masB[j])
                    z[i, j] = Met(i - 1, j - 1, z, masA, masB) + 1;
                else
                    z[i, j] = Math.Max(Met(i - 1, j, z, masA, masB), Met(i, j - 1, z, masA, masB));
            }

            return z[i, j];
        }

        static void Main()
        {
            string[] s = Console.ReadLine()?.Trim().Split(' ', ',', '.');

            if (s != null)
            {
                int n = int.Parse(s[0]);
                int m = int.Parse(s[1]);
                int[] masA = new int[n + 1];
                int[] masB = new int[m + 1];
                int[,] z = new int[n + 1, m + 1];

                for (int i = n; i >= 0; i--)
                {
                    for (int j = m; j >= 0; j--)
                    {
                        z[i, j] = -1;
                    }
                }

                string[] ss = Console.ReadLine()?.Trim().Split(' ', ',', '.');

                for (int i = 1; i < n + 1; i++)
                {
                    if (ss != null)
                    {
                        masA[i] = int.Parse(ss[i - 1]);
                    }
                }

                ss = Console.ReadLine()?.Trim().Split(' ', ',', '.');

                for (int i = 1; i < m + 1; i++)
                {
                    if (ss != null)
                    {
                        masB[i] = int.Parse(ss[i - 1]);
                    }
                }

                int result = Met(n, m, z, masA, masB);
                Console.WriteLine(result);
            }
        }
    }
}