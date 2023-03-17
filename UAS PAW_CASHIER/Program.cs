using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace UASPAWKASIR
{
    //Membuat Public Class
    public class Kasir
    {
        public void KasirCafe()
        {
            {

                Console.WriteLine("======================================");
                Console.WriteLine("          Program Kasir Cafe          ");
                Console.WriteLine("          Tes Kriuk Banguntapan       ");
                Console.WriteLine("======================================");
                Console.Write("\n");
                Console.WriteLine("   Silahkan Memilih Menu Makanan   ");
                Console.Write("\n");
                //Menampilkan Menu Makanan
                Console.WriteLine("==========MENU MAKANAN==========");
                Console.Write("\n");
                Console.WriteLine("  1. Pangsit Bakar     : Rp.10000");
                Console.WriteLine("  2. Pangsit Rebus     : Rp.15000");
                Console.WriteLine("  3. Pangsit Goreng    : Rp.20000");
                Console.Write("\n");
                //Menampilkan Menu Minuman
                Console.WriteLine("==========MENU MINUMAN==========");
                Console.Write("\n");
                Console.WriteLine("  1. Es Teros     : Rp.5000");
                Console.WriteLine("  2. Es Rexona    : Rp.6000");
                Console.WriteLine("  3. Es Gatsby    : Rp.5000");
                Console.Write("\n");

                int jumlah;
                //Looping dengan menginput jumlah barang menggunakan kondisi do while
                do
                {
                    Console.Write("\nMasukkan Jumlah Barang:  ");
                    jumlah = int.Parse(Console.ReadLine());
                } while (jumlah <= 0 || jumlah > 100);

                //Mendeklarasikan atau mendefiniskan variabel data
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;

                //Menampilkan nama pelanggan
                Console.WriteLine("===========================");
                Console.Write("Masukkan Nama Pelanggan : ");
                //Mendeklarasikan variabel data string
                string namap1 = Console.ReadLine();

                //Looping menggunakan kombinasi array
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //Menampilkan input nama barang
                        Console.WriteLine("=================================");
                        Console.Write("Masukkan Nama Barang Ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                    } //User harus menginput nama barang diatas 0 karakter sampai dengan 20 karakter
                    while (nama[i].Length <= 0 || nama[i].Length > 20);

                    do
                    {
                        //Menampilkan input harga data
                        Console.Write("Masukkan Harga Barang Ke-" + (i + 1) + ": ");
                        harga[i] = int.Parse(Console.ReadLine());
                    } //User harus menginput harga barang min 5000 sampai 1000000
                    while (harga[i] <= 4000 || harga[i] >= 1000000);

                }
                //Menampilkan barang yang sudah dipilih
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("Daftar Barang Yang Dipilih");
                Console.WriteLine("==========================");
                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + "." + nama[i] + " " + harga[i]);
                }
                foreach (int i in harga)
                {
                    total += i;
                }

                //Menampilkan total harga
                Console.WriteLine("=========================");
                Console.WriteLine("Total Harga  : Rp" + total);

                do
                {
                    Console.Write("Masukkan Tunai: Rp");
                    bayar = int.Parse(Console.ReadLine());

                    //Menampilkan kembalian uang dari uang yang dibayarkan dikurangi uang total
                    kembalian = bayar - total;

                    //Kondisi jika input uang yang dibayarkan kurang
                    if (bayar < total)
                    {
                        Console.WriteLine("Maaf Uangmu Tidak Cukup !");
                    }
                    //Kondisi dimana input uang yang diberikan lebih dan menambahkan uang kembalian
                    else
                    {
                        Console.WriteLine("Uang kembalian anda : Rp." + kembalian);
                    }

                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Pelanggan: {0}", namap1.ToString());
                Console.Write("\n");
                //Meanmpilkan tanggal dan waktu transaksi
                Console.WriteLine("Tanggal Transaksi:" + DateTime.Today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Jam Transaksi: " + DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("========================================");
                Console.WriteLine("Nama Kasir  : Gusmur Lebe");
                Console.WriteLine("Terima Kasih");
                Console.WriteLine("========================================");

                //Mencetak nota dengan menggunakan streamwritter
                using (StreamWriter sw = new StreamWriter(@"C:\Nota\sample2.txt"))//merupakan lokasi file nota dicetak
                {
                    sw.WriteLine("==========================================");
                    sw.WriteLine("============= NOTA PEMBAYARAN ============");
                    sw.WriteLine("==========================================");
                    sw.WriteLine("         Nama Barang Yang Dibeli          ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + " " + harga[i]);
                    }
                    sw.WriteLine("+==========================================+");
                    sw.WriteLine("Total Harga       : Rp" + total);
                    sw.WriteLine("Tunai             : Rp" + bayar);
                    sw.WriteLine("Kembalian         : Rp" + kembalian);
                    sw.WriteLine("\n");
                    //Menampilkan nama pelanggan
                    sw.WriteLine("Nama Pelanggan: {0}", namap1.ToString());
                    //Menampilkan tanggal dan waktu transaksi
                    sw.WriteLine("Tanggal Transaksi" + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam Transaksi: " + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("========================================");
                    sw.WriteLine("Nama Kasir  : Gusmur Lebe");
                    sw.WriteLine("Terima Kasih");
                    sw.WriteLine("========================================");
                    Console.WriteLine("\n");
                    Console.WriteLine("Nota Telah Dicetak");
                }
                Console.WriteLine();
                Console.Write("Tekan ENTER untuk Keluar...");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            //Memanggil kelas KasirCafe
            Kasir KasirB = new Kasir();
            KasirB.KasirCafe();
        }
    }
}