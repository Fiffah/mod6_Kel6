using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modul6_kelompok_6;

class main
{
    public static void Main()
    {
        DataMahasiswa_1302200121 mhsA1 = new DataMahasiswa_1302200121();
        mhsA1.ReadJSON();
        Console.WriteLine();

        TeamMembers_1302200121 mhsA2 = new TeamMembers_1302200121();
        mhsA2.ReadJSON();
        Console.WriteLine();
    }
}