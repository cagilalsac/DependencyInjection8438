using OgrenciApp.Models;

namespace OgrenciApp.Data
{
    public static class OgrenciData
    {
        public static Ogrenci[] Ogrenciler { get; set; }

        static OgrenciData()
        {
            //String x = "x";
            //x.Trim(); // string class'ındaki method

            //String.IsNullOrWhiteSpace(""); // string class'ındaki static bir method


            Ogrenciler = new Ogrenci[]
            {
                new Ogrenci()
                {
                    Id = 1,
                    Adi = "Çağıl",
                    Soyadi = "Alsaç"
                },
                 new Ogrenci()
                {
                    Id = 2,
                    Adi = "Leo",
                    Soyadi = "Alsaç"
                }
            };
        }
    }
}
