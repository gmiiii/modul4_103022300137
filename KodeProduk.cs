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
        string kodeProduk;

        public KodeProduk(string kode)
        {
            if (kode.Length != 4)
            {
                throw new ArgumentException("Kode produk harus terdiri dari 10 karakter.");
            }
            this.kodeProduk = kode;
        }

        public string getKodeProduk
        {
            get { return this.kodeProduk; }
        }
    }
}
