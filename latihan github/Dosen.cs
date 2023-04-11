using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_github
{
    class Dosen
    {
        private int id;
        private string nama;
        private int Nik;
        private string Gender;
        private string Course;

        public Dosen()
        {
            id = 1;
            nama = "Dosen Pengampu";
            Nik = 123456789;
            Gender = "Male";
            Course = "Pemrograman Berorientasi Objek";
        }

        public void attDosen(string name, int nik)
        {
            nama = name;
            Nik = nik;
        }

        public void addCourse(string course)
        {
            Course = course;
        }

        public void display()
        {
            Console.WriteLine("ID\t" + id);
            Console.WriteLine("Nama\t: " + nama);
            Console.WriteLine("Nik\t " + Nik);
            Console.WriteLine("Course\t " + Course);
            Console.WriteLine();
        }


    }
}
