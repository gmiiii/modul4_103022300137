using System;

namespace modul4_103022300137 { 
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Masukkan kode produk (4 karakter): ");
                string input = Console.ReadLine();
                KodeProduk produk = new KodeProduk(input);
                Console.WriteLine($"Kode produk yang valid: {produk.getKodeProduk}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");//
            }
        }
    }
}
