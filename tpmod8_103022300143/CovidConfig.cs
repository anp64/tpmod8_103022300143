using System.Text.Json;
using System.IO;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_demam { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    public static CovidConfig LoadConfig(string path)
    {
        string json = File.ReadAllText("D:\\konstruksi perangkat lunak\\tpmod8_103022300143\\tpmod8_103022300143\\covid_config.json");
        return JsonSerializer.Deserialize<CovidConfig>(json);
    }

    public void UbahSatuan()
    {
        if (satuan_suhu == "Celcius")
        {
            satuan_suhu = "Fahrenheit";
        }
        else
        {
            satuan_suhu = "Celcius";
        }
    }
}


