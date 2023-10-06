using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
           Musteri musteri1 = new Musteri();
            musteri1.Name = " Adem Arda ";
            musteri1.Surname = "Karademir";
            musteri1.Gender =" Erkek ";
            musteri1.TcNo = " 32262689157 ";
            
            Musteri musteri2 = new Musteri();
            musteri2.Name = "Doğukan";
            musteri2.Surname = "Üstündağ";
            musteri2.Gender = "Erkek";
            musteri2.TcNo = "78965432145";

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name+" "+musteri.Surname+" "+musteri.TcNo+" "+musteri.Gender);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri1);


        }
    }
}
