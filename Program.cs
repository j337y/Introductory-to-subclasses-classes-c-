using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvod_u_podklase_i_nadklase___c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zivotinja zivotinja = new Pas();

            zivotinja.Jedi();
            zivotinja.Glasaj_se(); 

            zivotinja = new Macka();
            zivotinja.Jedi();
            zivotinja.Glasaj_se();

            Console.ReadKey();
        }
    }
}
