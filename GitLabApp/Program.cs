using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GitLabApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sx = Console.ReadLine();
            double x = Convert.ToDouble(sx);
            double y = (Math.Sin(x) - Math.Cos(x)) / 5;
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
