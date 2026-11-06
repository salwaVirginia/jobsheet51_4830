Using System;

Class Program
{
    Static void Main()
    {
        // 1. Deklarasi Konstanta
        Const int BIAYA_ADMINISTRASI = 2000;

        // 2. Input
        Console.Write(“Masukkan nama pelanggan: “);
        String namaPelanggan = Console.ReadLine();

        Console.Write(“Masukkan jumlah halaman: “);
        Int jumlahHalaman = Convert.ToInt32(Console.ReadLine());

        Console.Write(“Masukkan harga per halaman: “);
        Int hargaPerHalaman = Convert.ToInt32(Console.ReadLine());

        // 3. Process
        Int subtotal = jumlahHalaman * hargaPerHalaman;
        Int totalBayar = subtotal + BIAYA_ADMINISTRASI;

        // 4. Output
        Console.WriteLine(“\n=== RINCIAN PENCETAKAN ===”);
        Console.WriteLine(“Nama pelanggan     = “ + namaPelanggan);
        Console.WriteLine(“Jumlah halaman     = “ + jumlahHalaman);
        Console.WriteLine(“Harga per halaman  = “ + hargaPerHalaman);
        Console.WriteLine(“Subtotal           = “ + subtotal);
        Console.WriteLine(“Biaya administrasi = “ + BIAYA_ADMINISTRASI);
        Console.WriteLine(“Total bayar        = “ + totalBayar);
    }
}
