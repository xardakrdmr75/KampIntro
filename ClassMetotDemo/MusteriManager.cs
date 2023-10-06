using System;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + "Kişisi Eklendi");
        }
        public void Delete (Musteri musteri1)
        {
            Console.WriteLine(musteri1.Name + "" + musteri1.Surname + "Kişisi Silindi");
        }
    }
}
