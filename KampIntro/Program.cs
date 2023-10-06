/*
  Type safety = tip güvenliği
  Do not repeat yourself = kendini tekrarlama
  Değer tutucu = alias
 */
public class Program
{
    public static void Main(string[] args)
    {
        string KategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = true;
        double dolarDun = 7.35;
        double dolarBugun = 8.35;

        if (dolarDun > dolarBugun)
        {
            Console.WriteLine("Azalış butomu");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış butonu");
        }
        else
        {
            Console.WriteLine("Değişmedi butonu");
        }
        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }
        Console.WriteLine(KategoriEtiketi);
    }
}