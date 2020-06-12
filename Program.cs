using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.Nim = "2829";
            mhs.Nama = "Rahma Pamela";
            mhs.Registrasi();

            Console.ReadKey();
        }
    }
}

