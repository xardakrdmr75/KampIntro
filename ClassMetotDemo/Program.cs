using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Console.WriteLine("Müşterinin ismini giriniz:  ");
            musteri1.Name = Console.ReadLine();
            musteri1.Surname = "Karademir";
            musteri1.Gender = " Erkek ";
            musteri1.TcNo = " 32262689157 ";

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Doğukan";
            musteri2.Surname = "Üstündağ";
            musteri2.Gender = "Erkek";
            musteri2.TcNo = "78965432145";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + musteri.TcNo + " " + musteri.Gender);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri1);


            Musteri musteri3 = new Musteri();
            Console.WriteLine("Müşterinin ismini giriniz:  ");
            musteri3.Name = Console.ReadLine();
            Console.WriteLine("Müşterinin soyismini giriniz:  ");
            musteri3.Surname = Console.ReadLine();
            Console.WriteLine("Müşterinin TcNo giriniz:  ");
            musteri3.TcNo = Console.ReadLine();
            Console.WriteLine("Müşterinin cinseyitini giriniz:  ");
            musteri3.Gender = Console.ReadLine();
            Console.WriteLine("Müşterinin annesinin kızlık soyadı:  ");
            musteri3.MaidenName = Console.ReadLine();
            Console.WriteLine("Müşterinin üstüne kayıtlı kaç tane mülk var:  ");
            try
            {
                musteri3.CountOfProperty = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mülk Sayısı yanlış girildi");
                musteri3.CountOfProperty = 0;
            }
            Console.WriteLine(musteri3.Name + " " + musteri3.Surname + " " + musteri3.TcNo + " " + musteri3.Gender + " " + musteri3.MaidenName + " " + musteri3.CountOfProperty);
        }
    }
}
