﻿namespace modul6_Kelompok_6
{
    internal class DataMahasiswa_1302204070
    {
        public static void readJSON()
        {
            String jsonString = File.ReadAllText("C:\\Users\\ASUS\\source\\repos\\jurnal6_1_1302204070");

            dynamic data = JsonConvert.DeserializeObject(jsonString);



            Console.WriteLine("Nama : " + data.firstName + " " + data.lastName);
            Console.WriteLine("Gender : " + data.gender);
            Console.WriteLine("Umur : " + data.age);
            Console.WriteLine("Alamat : " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
            Console.WriteLine("Mata Kuliah : ");
            foreach (var item in data.courses)
            {
                Console.WriteLine();
                Console.WriteLine("Kode matkul : " + item.code);
                Console.WriteLine("Nama matkul : " + item.name);
            }
            Console.WriteLine();
        }
    }
}