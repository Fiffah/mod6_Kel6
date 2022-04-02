using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul6_kelompok_6
{
    class DataMahasiswa_1302204118
    {
        public TeamMember[] members { get; set; }

        public void ReadJSON()
        {
            string fileName = "jurnal6_2_1302204118.json";

            var jsonString = File.ReadAllText(fileName);
            DataMahasiswa_1302204118 jsonData = JsonSerializer.Deserialize<DataMahasiswa_1302204118>(jsonString);

            this.members = jsonData.members;

            this.info();
        }

        public void info()
        {
            Console.WriteLine("Nama Kelompok:");
            foreach (var team in members)
            {
                team.info();
            }
        }
    }

    class TeamMember
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public void info()
        {
            Console.WriteLine(this.nim + " " + this.firstName + " " + this.lastName + " ("
                + this.age + " " + this.gender + ")");
        }
    }
}