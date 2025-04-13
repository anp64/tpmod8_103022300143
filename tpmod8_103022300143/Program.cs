using System;

class Program
{
    static void Main()
    {
        // Load konfigurasi
        CovidConfig config = CovidConfig.LoadConfig("D:\\konstruksi perangkat lunak\\tpmod8_103022300143\\tpmod8_103022300143\\covid_config.json");
        
        // Input suhu
        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        
        double suhu = Convert.ToDouble(Console.ReadLine());

        // Input hari
        Console.Write($"Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?  ");
        int hari = Convert.ToInt32(Console.ReadLine());

        // Validasi suhu berdasarkan satuan
        bool suhuValid = false;
        if (config.satuan_suhu == "Celcius")
        {
            suhuValid = suhu >= 36.5 && suhu <= 37.5;
        }
        else if (config.satuan_suhu == "Fahrenheit")
        {
            suhuValid = suhu >= 97.7 && suhu <= 99.5;
        }

        // Validasi hari
        bool hariValid = hari < config.batas_hari_demam;

        // Output sesuai kondisi
        if (suhuValid && hariValid)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }

        // Contoh ubah satuan (jika mau digunakan)
        // config.UbahSatuan();
        // Console.WriteLine($"Satuan sekarang: {config.satuan_suhu}");
    }
}
