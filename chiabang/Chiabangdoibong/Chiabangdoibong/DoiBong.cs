using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiabangdoibong
{
    class DoiBong
    {
            private string name;
            public string Name { get => name; set => name = value;}
            private decimal win_rate;
            
            public decimal Win_rate { get => win_rate; set => Win_rate = Convert.ToDecimal(win_rate); }
            
            public void NhapDB()
            {
                Console.Write("Nhap Ten Doi Bong: ");
                name = Console.ReadLine();
                Console.Write("Nhap Ty Le Thang: ");
                win_rate = Convert.ToDecimal(Console.ReadLine());

             }

    }
}

