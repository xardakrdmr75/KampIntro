
using ClassIntro;

class Program
{
    static void Main(string[] args)
    {
        string adi = "Arda";
        int yas = 17;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Adem Arda";
        kurs1.IzlenmeOrani = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Doğukan Üstündağ";
        kurs2.IzlenmeOrani = 64;


        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Recai Emir";
        kurs3.IzlenmeOrani = 80;

        Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

        Hello();
    }
    static void Hello()
    {
        Console.WriteLine("metot çalıştı");
    }
}


