using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=== KALKULATOR SEDERHANA ===");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilih operasi (1-5): ");

            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Write("Masukkan angka pertama: ");
                    int angka1 = int.Parse(Console.ReadLine());

                    Console.Write("Masukkan angka kedua: ");
                    int angka2 = int.Parse(Console.ReadLine());

                    int hasilPenjumlahan = angka1 + angka2;
                    Console.WriteLine("Hasil: " + hasilPenjumlahan);
                    break;

                case 2:
                    Console.Write("Masukkan angka pertama: ");
                    angka1 = int.Parse(Console.ReadLine());

                    Console.Write("Masukkan angka kedua: ");
                    angka2 = int.Parse(Console.ReadLine());

                    int hasilPengurangan = angka1 - angka2;
                    Console.WriteLine("Hasil: " + hasilPengurangan);
                    break;

                case 3:
                    Console.Write("Masukkan angka pertama: ");
                    angka1 = int.Parse(Console.ReadLine());

                    Console.Write("Masukkan angka kedua: ");
                    angka2 = int.Parse(Console.ReadLine());

                    int hasilPerkalian = angka1 * angka2;
                    Console.WriteLine("Hasil: " + hasilPerkalian);
                    break;

                case 4:
                    Console.Write("Masukkan angka pertama: ");
                    angka1 = int.Parse(Console.ReadLine());

                    Console.Write("Masukkan angka kedua: ");
                    angka2 = int.Parse(Console.ReadLine());

                    if (angka2 == 0)
                    {
                        Console.WriteLine("Tidak bisa melakukan pembagian dengan angka 0");
                    }
                    else
                    {
                        double hasilPembagian = (double)angka1 / angka2;
                        Console.WriteLine("Hasil: " + hasilPembagian);
                    }
                    break;

                case 5:
                    Console.WriteLine("Terima kasih telah menggunakan kalkulator sederhana");
                    return;

                default:
                    Console.WriteLine("Pilihan tidak valid");
                    break;
            }

            Console.WriteLine("Tekan tombol sembarang untuk melanjutkan...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
