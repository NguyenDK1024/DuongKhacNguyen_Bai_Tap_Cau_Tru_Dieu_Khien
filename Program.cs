using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongKhacNguyen_BaiTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Bai 1
            //Console.Write("nhap vao so nguyen A = ");
            //int A = int.Parse(Console.ReadLine());
            //if (A % 3 == 0) Console.WriteLine("So {0} chia het cho 3", A);
            //else Console.WriteLine("So {0} khong chia het cho 3", A);
            ///////////////////////////////////////////////

            //Bai 2
            //Console.Write("nhap vao so nguyen duong (n tu 1 den 10) n = ");
            //int n = int.Parse(Console.ReadLine());
            //if (n > 10 || n < 1) Console.WriteLine("So nay khong hop le");
            //else
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        for (int j = 0; j <= 10; j++)
            //        {
            //            if (j == 0) Console.WriteLine("Bang cuu chuong {0}", i);
            //            else Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
            //        }
            //    }
            //}
            ////////////////////////////////////////////////

            ////Bai 3
            //Console.Write("nhap vao so nguyen duong (n > 0) n = ");
            //int n = int.Parse(Console.ReadLine());
            //int s = 0;
            //if (n < 1) Console.WriteLine("So nay khong hop le");
            //else
            //{
            //    for (int i = n; i > 0; i--)
            //    {
            //        int t = 1;
            //        for (int j = i; j > 0; j--)
            //        {
            //            t = t * j;
            //            if (j == 1) s = s + t;
            //        }
            //        if (i == 1) Console.WriteLine("Tong giai thua tu 1 den {0} la: {1}", n, s);
            //    }
            //}
            //////////////////////////////////////////////////////////////////////

            ///Bai 4
            //Console.Write("nhap vao so nguyen duong (n > 0) n = ");
            //int n = int.Parse(Console.ReadLine());
            //string Kq = ("Day khong phai la so chinh phuong");
            //if (n > 0)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (i * i == n) Kq = ("Day la so chinh phuong");
            //    }
            //}
            //if (n == 0) Kq = ("Day la so chinh phuong");
            //Console.WriteLine(Kq);
            /////////////////////////////////////////////////////////////////////

            /////Bai 5
            //Console.Write("nhap vao so thang: ");
            //int so_thang = int.Parse(Console.ReadLine());
            //switch (so_thang)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 10:
            //    case 12:
            //        int so_ngay = 31;
            //        Console.WriteLine(so_ngay);
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        so_ngay = 30;
            //        Console.WriteLine(so_ngay);
            //        break;
            //    case 2:
            //        Console.Write("nhap so nam:"); int so_nam = int.Parse(Console.ReadLine());
            //        so_ngay = DateTime.DaysInMonth(so_nam, so_thang);
            //        Console.WriteLine(so_ngay);
            //        break;
            //    default:
            //        Console.WriteLine("khong ton tai thang {0}", so_thang);
            //        break;
            //}
            ///////////////////////////////////////////////////////////////////

            ///Bai 6
            //Console.Write("nhap vao so nguyen duong (n > 0) n = ");
            //double n = double.Parse(Console.ReadLine());
            //if (n>0)
            //{
            //    double s = 0;
            //    for (double i = 1; i <=n; i++)
            //    {                    
            //        s=s+Math.Pow(i, i);

            //    }
            //    Console.Write("Tong can tim la s = {0}",s);
            //}
            //else Console.WriteLine("So nay khong hop le");
            ///////////////////////////////////////////////////////////////////

            ///Bai 7
            //Console.Write("nhap vao so nguyen n = ");
            //int n = int.Parse(Console.ReadLine());
            //int s = 0;
            //if (n < 1) Console.Write("So nay khong hop le");
            //else
            //{
            //    for (int i = 1; i <= n; i += 2)
            //    {
            //        s = s + i;
            //    }
            //    Console.WriteLine("Tong so le tu 1 den {0} la: {1}", n, s);
            //}
            /////////////////////////////////////////////////////////////////


            ///Bai 8            
            //Console.Write("nhap vao so nguyen duong (n > 0) n = ");
            //int n = int.Parse(Console.ReadLine());
            //if (n < 2) Console.WriteLine("Khong ton tai so nguyen to");
            //else
            //{
            //    Console.WriteLine("2");
            //    for (int i = 3; i <= n; i++)
            //    {
            //        if (i % 2 == 0) continue;
            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //                break;
            //            if (j == i - 1) Console.WriteLine("{0}", i);
            //        }
            //    }
            //}
            ///////////////////////////////////////////////////////////////////


            /////Bai 9
            //Console.Write("nhap vao so hang n = ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Loai tam giac");
            //Console.WriteLine("tam giac vuong dung nhap vao so 1");
            //Console.WriteLine("tam giac vuong nguoc nhap vao so 2");
            //Console.WriteLine("tam giac vuong dung nhap vao so 3");
            //int type = int.Parse(Console.ReadLine());
            //if (type != 1 && type != 2 && type != 3 || n <= 0) Console.WriteLine("So khong hop le");
            //else
            //{
            //    switch (type)
            //    {
            //        case 1:
            //            for (int i = 1; i <= n; i++)
            //            {
            //                for (int j = 1; j <= i; j++)
            //                {
            //                    Console.Write("*");
            //                    if (j == i) Console.WriteLine();
            //                }
            //            }
            //            break;
            //        case 2:
            //            for (int i = n; i > 0; i--)
            //            {
            //                for (int j = 1; j <= i; j++)
            //                {
            //                    Console.Write("*");
            //                    if (j == i) Console.WriteLine();
            //                }
            //            }
            //            break;
            //        case 3:
            //            for (int i = 1; i <= n; i++)
            //            {
            //                for (int j = 1; j <= 2 * n - 1; j++)
            //                {
            //                    if (j == 2 * n - 1 && i != n) Console.WriteLine(); //Xuong hang khi con tro den cuoi hang ngoai tru dong cuoi cung
            //                    else if (j == (n + 1) - i || j == (n - 1) + i) Console.Write("*");//Nhap * vao 2 canh ben                                
            //                    else if ((j - (n + 1 - i)) % 2 == 0 && n + 1 - i < j && j < n - 1 + i) Console.Write("*");//Kiem tra so j co lon hon chan lan so dau hang khong de nhap * vao canh day
            //                    else Console.Write(" ");
            //                }
            //            }

            //            break;
            //    }
            //}
            ///////////////////////////////////////////////////////////


            ////Bai 10
            //Console.Write("nhap vao so phan tu Fibonaci n = ");
            //int n = int.Parse(Console.ReadLine());
            //int A = 0; int B = 1; int C = 0;
            //if (n <= 0) Console.WriteLine("So khong hop le");
            //if (n == 1)
            //{
            //    Console.WriteLine("Day Fibonaci voi {0} phan tu la:", n);
            //    Console.Write(A);
            //}
            //if (n > 1)
            //{
            //    Console.WriteLine("Day Fibonaci voi {0} phan tu la:", n);
            //    for (int i = 1; i <= n; i++)
            //    {
            //        if (i == 1) Console.Write(A + "   ");
            //        C = A + B; B = A; A = C;
            //        Console.Write(C + "   ");
            //    }
            //}
            ///////////////////////////////////////////////////////////////


            Console.ReadKey();
        }
      
    }
}
