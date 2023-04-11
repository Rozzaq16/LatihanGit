using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_github
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen = new Dosen();
            Console.WriteLine("default Dosen pengampu!");
            dosen.display();

            Console.WriteLine("\nMasukan Nama dan NIK Dosen Baru:");
            dosen.attDosen(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            dosen.display();

            Console.WriteLine("\nMasukan Mata Kuliah Baru:");
            dosen.addCourse(Console.ReadLine());
            dosen.display();

            Console.ReadLine();

        }
    }
}
