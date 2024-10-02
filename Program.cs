// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace MyProject;

class Program
{
    static void Main(string[] args)
    {

        // ============= SOAL NO 1 ================== //


        // string merkMobil;
        // string warnaMobil;
        // int jumlahMobil;

        // Console.WriteLine("======== SHOWROOM MOBIL DASPRO JAYA ========");
        // Console.WriteLine("\n");
        // Console.WriteLine("===== INPUT DISINI YUK! =====");
        // Console.WriteLine("\n");

        // Console.Write("Masukan merk mobil: ");
        // merkMobil = Console.ReadLine();

        // Console.Write("Masukan warna mobil: ");
        // warnaMobil = Console.ReadLine();

        // Console.Write("Hitung jumlah mobil: ");
        // jumlahMobil = int.Parse(Console.ReadLine());
        // Console.WriteLine("\n");

        // Console.WriteLine("===== DATA SHOWROOM MOBIL DASPRO JAYA =====");
        // Console.WriteLine("\n");
        // Console.WriteLine("Mobil bermerk: " + merkMobil);
        // Console.WriteLine("Mobil berwarna: " + warnaMobil);
        // Console.WriteLine("Mobil berjumlah: " + jumlahMobil);


        // ============= SOAL NO 2 ================== //


        int jumlahKemeja;
        int jumlahKaos;
        int jumlahSweater;
        int totalPakaian;

        Console.WriteLine("================ BUTIK IMPIAN ZEE =================");
        Console.WriteLine("\n");
        Console.WriteLine("======= INPUT JUMLAH PAKAIAN YUK! ========");
        Console.WriteLine("\n");
        
        Console.Write("Jumlah pakaian Kemeja: ");
        jumlahKemeja = int.Parse(Console.ReadLine());

        Console.Write("Jumlah pakaian Kaos: ");
        jumlahKaos = int.Parse(Console.ReadLine());

        Console.Write("Jumlah pakaian Sweater: ");
        jumlahSweater = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        totalPakaian = jumlahKemeja + jumlahKaos + jumlahSweater;
        Console.WriteLine("Total jumlah pakaian di Butik Impian Zee berjumlah " + totalPakaian + " buah");

    }
}

