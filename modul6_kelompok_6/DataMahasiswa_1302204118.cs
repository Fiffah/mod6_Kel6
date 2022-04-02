using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_kelompok_6
{

    public class DataMahasiswa_1302202095
    {
        private readonly string fileName;

        public class data1
        {
            public string firstName;
            public string lastName;
            public string gender;
            public int age;
        }

        public void ReadJSON()
        {

            var jsonString = File.ReadAllText(fileName);
            DataMahasiswa_1302202095 data1 = JsonSerializer.Deserialize<DataMahasiswa_1302202095>(jsonString);


            Console.WriteLine($"Nama {dataMahasiswa.firstname} {dataMahasiswa.lastname} berusia {dataMahasiswa.age} dan bejenis kelamin {dataMahasiswa.gender}");
        }
    }
}