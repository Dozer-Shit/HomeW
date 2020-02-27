using System;

namespace HomeWork4
{
    class RankArray
    {
        public int[,] ArrRank { get; }

        public RankArray(int size1, int size2)
        {
            ArrRank = new int[size1, size2];
            Random rand = new Random();
            for (int i = 0; i < ArrRank.GetLength(0); i++)
            {
                for (int j = 0; j < ArrRank.GetLength(1); j++)
                {
                    ArrRank[i, j] = rand.Next(100);
                }
            }
        }

        public static void RankSum(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
        }

        public static void RankSumMoreThan(int[,] arr, int min)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > min)
                    {
                        sum += arr[i, j];
                    }
                }
            }
        }

        public int MinElem
        {
            get
            {
                int min = ArrRank[0, 0];
                for (int i = 0; i < ArrRank.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrRank.GetLength(1); j++)
                    {
                        if (ArrRank[i, j] < min)
                        {
                            min = ArrRank[i, j];
                        }
                    }
                }

                return min;
            }

        }

        public int MaxElem
        {
            get
            {
                int max = ArrRank[0, 0];
                for (int i = 0; i < ArrRank.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrRank.GetLength(1); j++)
                    {
                        if (ArrRank[i, j] > max)
                        {
                            max = ArrRank[i, j];
                        }
                    }
                }

                return max;
            }
        }

        public static void MaxNum(int[,] arr, out int[] MaxNum)
        {
            int max = arr[0,0];
            
            MaxNum = new int[2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        MaxNum[0] = i + 1;
                        MaxNum[1] = j + 1;
                        
                    }
                }
            }
        }
    }
}