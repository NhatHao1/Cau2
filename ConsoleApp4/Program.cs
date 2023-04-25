using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        int m, n;

        // Nhập số hàng và số cột của ma trận
        Console.WriteLine("Nhập số hàng của ma trận: ");
        m = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập số cột của ma trận: ");
        n = int.Parse(Console.ReadLine());

        // Nhập ma trận A
        Console.WriteLine("Nhập ma trận A:");
        int[,] A = NhapMaTran(m, n);

        // Nhập ma trận B
        Console.WriteLine("Nhập ma trận B:");
        int[,] B = NhapMaTran(m, n);

        // Tính tổng của hai ma trận
        int[,] C = TinhTongMaTran(A, B);

        // In ra ma trận C
        Console.WriteLine("Ma trận C là:");
        InMaTran(C);

        Console.ReadLine();
    }

    static int[,] NhapMaTran(int m, int n)
    {
        int[,] matran = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("matran[{0},{1}] = ", i, j);
                matran[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matran;
    }

    static int[,] TinhTongMaTran(int[,] A, int[,] B)
    {
        int m = A.GetLength(0);
        int n = A.GetLength(1);
        int[,] C = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }
        return C;
    }

    static void InMaTran(int[,] matran)
    {
        int m = matran.GetLength(0);
        int n = matran.GetLength(1);
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", matran[i, j]);
            }
            Console.WriteLine();
        }
    }
}
