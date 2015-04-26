using System;


namespace Ex_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[2, 3];
            int[,] matrixB = new int[3, 4] { { 4, 2, 1, 7 }, { 3, 6, 1, 0 }, { 5, 3, 2, 4 } };
            int[,] matrixC = new int[2, 4];

            for(int i = 0;i <2;++i)
            {
                for(int j = 0;j<3;++j)
                {
                    matrixA[i, j] = (i + 2) * (j + 2) + 1;
                }
            }

            for(int i = 0;i <2;++i)
            {
                for(int j = 0;j<4;++j)
                {
                    matrixC[i, j] = 0;
                    for(int k = 0;k <3;++k)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            Console.WriteLine("\n MatrixA");
            outputMatrix(matrixA, 2, 3);
            Console.WriteLine("\n MaxtixB");
            outputMatrix(matrixB, 3, 4);
            Console.WriteLine("\n MatrixA * MaxtixC");
            outputMatrix(matrixC, 2, 4);

            Console.ReadLine();
        }


        public static void outputMatrix(int[,]matrixX,int rowCount,int columnCount)
        {
            if (matrixX.Length != rowCount * columnCount)
            {
                Console.WriteLine("Wrong Row or Column");
                return;
            }

            for(int i = 0;i <rowCount;++i)
            {
                for(int j = 0; j <columnCount;++j)
                {
                    Console.Write(matrixX[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
