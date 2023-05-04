using System;

class HesapMakinesi
{
    static void Main()
    {
        while (true)
        {
            Console.Write("İlk sayınızı giriniz.");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayınızı giriniz.");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("\t1 - Toplama");
            Console.WriteLine("\t2 - Çıkarma");
            Console.WriteLine("\t3 - Çarpma");
            Console.WriteLine("\t4 - Bölme");

            int secim = Convert.ToInt32(Console.ReadLine());
            double sonuc = O;
            string islem = "";

            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
                islem = "Toplama";
            }
            else if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
                islem = "Çıkarma";
            }
            else if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
                islem = "Çarpma";
            }
            else if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
                islem = "Bölme";
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
                continue;
            }

            Console.WriteLine("{0} işlemi sonucu: {1}", islem, sonuc);

            do
            { 
            Console.WriteLine("Yeniden hesaplama yapmak istiyor musunuz? (E/H)");
            string devam = Console.ReadLine().ToUpper();


            } while (devam != "E" && devam != "H");

            if (devam == "H")
            {
                break;
            }
        }

        Console.WriteLine("Program sonlandırıldı.");
    }
}