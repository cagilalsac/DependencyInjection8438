KamyonSurucu surucu1 = new KamyonSurucu()
{
    Soyadi = "Alsaç",
    Adi = "Çağıl",
    EhliyetNo = "1234"
};
Araba araba = new Araba(surucu1);
araba.Sur();
ArabaSurucu surucu2 = new ArabaSurucu()
{
    Soyadi = "Uzun",
    Adi = "Zahide",
    EhliyetNo = "4321"
};
araba = new Araba(surucu2);
araba.Sur();

class Araba
{
    private readonly SurucuBase _surucu;

    public Araba(SurucuBase surucu)
    { // constructor injection
        _surucu = surucu;
    }

    public void Sur()
    { 
        Console.WriteLine(_surucu.Adi + " " + _surucu.Soyadi + " tarafından sürülüyor");
    }
}

abstract class SurucuBase
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public  string EhliyetNo { get; set; }
}

class ArabaSurucu : SurucuBase
{

}

class KamyonSurucu : SurucuBase
{

}