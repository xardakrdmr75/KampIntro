using Gun2_Odev6;

class Program
{
    public static void Main(string[] args)
    {
        #region örnek_1
        //Product urun1 = new Product();
        //urun1.Id = 1;
        //urun1.Name = "Lenovo Laptop";
        //urun1.Price = 12000;
        //urun1.Description = "Oyun bilgisayarı";

        //Product urun2 = new Product();
        //urun2.Id = 2;
        //urun2.Name = "Casper Laptop";
        //urun2.Price = 12000;
        //urun2.Description = "Oyun bilgisayarı";

        //Product urun3 = new Product();
        //urun3.Id = 3;
        //urun3.Name = "MSI Laptop";
        //urun3.Price = 18000;
        //urun3.Description = "Oyun bilgisayarı";

        //Product[] urunler = new Product[] { urun1, urun2, urun3 };
        //foreach (var product in urunler)
        //{
        //    Console.WriteLine("#" + product.Id + " - " + product.Name + " - " + 
        //    product.Description + " - " + product.Price + " TL ");
        //} 
        #endregion
     Car car1 = new Car();
     car1.Id = 1;
     car1.Name = "Ford";
     car1.Description = "ülkenin en büyük otomobil üreticisi konumundadır";
     car1.brand = "2023";
     car1.Grill = " otomobiller için yüksek mukavemetli plastik";
     car1.engine = " 1.5 lt Ti-VCT motor ile 123 beygir güç ve 150 Nm tork";
     car1.price = 200;

        Car car2 = new Car();
        car2.Id = 2;
        car2.Name = "Wolswagen";
        car2.Description = "2017, 2018 ve 2019'da 10.9 milyon araç satarak, dünyanın en büyük otomobil üreticisi oldu.";
        car2.brand = "2023";
        car2.Grill = "Tampon Orta Izgara Yan Sanayi  bir üründür. Garantisi mevcuttur";
        car2.engine = "beygir gücü 110(150) / 5000-6000 kW ";
        car2.price = 300;

        Car car3 = new Car();
        car3.Id = 3;
        car2.Name = "Fiat";
        car2.Description = "2015'te Türkiye'de satışa sunulan, C segmenti bir aile otomobilidir.";
        car2.brand = "2020";
        car2.Grill = "Fiat Egea Ön Panjur Izgarası Krom Nikelajlı (735642866)";
        car2.engine = "1.6 MultiJet II 120 HP DCT.";
        car2.price = 400;

        foreach (Product product in cars)
        {
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Description);
            Console.WriteLine(product.brand);
            Console.WriteLine(product.Grill);
            Console.WriteLine(product.Price + " $");
        }
        Console.WriteLine("foreach bitti");
        int counter = 1;
        while (counter <= Car.)
        {
            Console.WriteLine("Ürün " + counter + ":");
            Console.WriteLine("Adı: " + (counter == 1 ? car1.Name : car1.Name));
            Console.WriteLine("Açıklama: " + (counter == 1 ? car1.Description : car2.Description));
            Console.WriteLine("Fiyatı: " + (counter == 1 ? car1.Price : car1.Price));
            counter++;
        }
        Console.WriteLine("while chat gpt bitti");
        int a = 0;
        while (a < Car.Length)
        {
            Console.WriteLine(Car[a].Name);
            Console.WriteLine(Car[a].Price + Car[a].Explanation);
        }
        Console.WriteLine("while döngüsü bitti");










    }
}
