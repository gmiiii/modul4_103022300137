using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300137
{
    public class KodeProduk
    {
        //buat enum untuk produk elektronik yang tiap enum memiliki kode produk yang berbeda diambil dari list produk dan ditentukan pada method getKodeProduk
        public enum ProdukElektronik
        {
            LAPTOP,
            SMARTPHONE,
            TABLET,
            HEADSET,
            KEYBOARD,
            MOUSE,
            PRINTER,
            MONITOR,
            SMARTWATCH
        }

        private static String[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };

        public String getKodeProduk() 
        {
            String kode = "";
            foreach (ProdukElektronik produk in Enum.GetValues(typeof(ProdukElektronik)))
            {
                kode += $"{produk.ToString()} - {kodeProduk[(int)produk]}\n";
            }
            return kode;
        }

    }
}
