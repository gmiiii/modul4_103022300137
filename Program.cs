using System;

namespace modul4_103022300137 { 
    public class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek KodeProduk
            KodeProduk kodeProduk = new KodeProduk();
            Console.WriteLine("Daftar Kode Produk Elektronik:");
            Console.WriteLine(kodeProduk.getKodeProduk());
            // Membuat objek FanLaptop
            FanLaptop fanLaptop = new FanLaptop();
            Console.WriteLine("Mengatur mode kipas ke QUIET:");
            fanLaptop.SetFanState("QUIET");
            Console.WriteLine("Mengatur mode kipas ke BALANCED:");
            fanLaptop.SetFanState("BALANCED");
            Console.WriteLine("Mengatur mode kipas ke TURBO:");
            fanLaptop.SetFanState("TURBO");
        }
    }
}
