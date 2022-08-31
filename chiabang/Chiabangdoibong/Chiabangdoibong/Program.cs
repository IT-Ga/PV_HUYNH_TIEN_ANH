using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiabangdoibong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so doi bong :");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if ((n >= 4) && (n % 2 == 0))
            {
                DoiBong[] a = new DoiBong[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap Thong Tin DB THU " + (i + 1));
                    a[i] = new DoiBong();
                    a[i].NhapDB();
                }
                DoiBong tb;
                //Chia logic theo 2 bang dau 
                //sap xep Win Rate
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i].Win_rate < a[j].Win_rate)

                        {
                            tb = a[i];
                            a[i] = a[j];
                            a[j] = tb;
                        }
                    }
                }
                // Chia thanh 2 bang
                Console.WriteLine("\n Bang A gom :");
                for (int i = 0; i < n/2; i++)
                {
                    Console.WriteLine("\n Doi Thu {0} TenDB: {1} | Win_rate: {2} ", i+1, a[i].Name, a[i].Win_rate);
                    
                }

                Console.WriteLine("\n Bang B gom :");
                for (int i = n-1; i > n/2-1  ; i--)
                {
                    Console.WriteLine("\n Doi Thu {0} TenDB: {1} | Win_rate: {2} ", n-(i), a[i].Name, a[i].Win_rate);
                    
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" So Doi Bong Khong Thoa Dieu Kien Chia Bang ");
                Console.WriteLine(" Dieu Kien Chia Bang Dau : ");
                Console.WriteLine(" 1 - So Doi Bong Phai La So Chan ");
                Console.WriteLine(" 2 - So Doi Bong Phai Lon Hon 4 ");
                Console.ReadKey();
            }    
        }
    }
}
