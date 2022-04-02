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
        TeamMember_1302204118 mhsA1 = new TeamMember_1302204118();
        mhsA1.ReadJSON();
        Console.WriteLine();

        TeamMember_1302204118 mhsA2 = new TeamMember_1302204118();
        mhsA2.ReadJSON();
        Console.WriteLine();

        GlossaryItem_1302204118 mhsA3 = new GlossaryItem_1302204118();
        mhsA3.ReadJSON();
    }
}