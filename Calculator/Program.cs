using System;

namespace Calculator
{
    /// <summary>
    /// Class Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deklarasi varible static
        /// dengan tipe data integer
        /// yaitu varible angka1 dan angka2 sebagai inputan
        /// </summary>
        public static int angka1, angka2;

        /// <summary>
        /// Method Menu Calculator 2 variable
        /// Pertambahan, pengurangan, dan perkalian
        /// </summary>
        public void menu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Menu Calculator");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. Pertambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Exit");
        }
        /// <summary>
        /// Method Input angka pertama dan angka kedua
        /// </summary>
        public void input()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Calculatorku");
            Console.WriteLine("------------------\n");

            Console.Write("Masukkan Angka Pertama: ");
            angka1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Angka Kedua: ");
            angka2 = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Method Pertambahan dengan menggunakan membalikkan nilai
        /// </summary>
        /// <param name="a"> menyimpan nilai inputan angka pertama</param>
        /// <param name="b">menyimpan nilai inputan angka kedua</param>
        /// <returns>Membalikkan nilai Hasil Pertambahan dan menampilkan hasilnya</returns>
        public int hitung_tambah(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Method Pengurangan dengan menggunakan method membalikkan nilai
        /// </summary>
        /// <param name="a"> menyimpan nilai inputan angka pertama</param>
        /// <param name="b">menyimpan nilai inputan angka kedua</param>
        /// <returns>Membalikkan nilai hasil Pengurangan dan menampilkan hasilnya</returns>
        public int hitung_kurang(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// Method Perkalian dengan menggunakan method membalikkan nilai
        /// </summary>
        /// <param name="a"> menyimpan nilai inputan angka pertama</param>
        /// <param name="b">menyimpan nilai inputan angka kedua</param>
        /// <returns>Membalikan nilai hasil Perkalian dan menampilkannya</returns>
        public int hitung_kali(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// Method untuk menampilkan Hasil data Pertambahan
        /// dan menampilkan nilai inputan angka pertama dan kedua
        /// </summary>
        public void display_tambah()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Hasil Penambahan");
            Console.WriteLine("------------------\n");
            Console.WriteLine("Angka Pertama: " + angka1);
            Console.WriteLine("Angka Kedua: " + angka2);
            Console.WriteLine("Hasil : " + hitung_tambah(angka1,angka2) + "\n");
        }
        /// <summary>
        /// Method untuk menampilkan Hasil data Pengurangan
        /// dan menampilkan nilai inputan angka pertama dan kedua
        /// </summary>
        public void display_kurang()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Hasil Pengurangan");
            Console.WriteLine("------------------\n");
            Console.WriteLine("Angka Pertama: " + angka1);
            Console.WriteLine("Angka Kedua: " + angka2);
            Console.WriteLine("Hasil : " + hitung_kurang(angka1,angka2) + "\n");
        }
        /// <summary>
        /// Method untuk menampilkan Hasil data Perkalian
        /// dan menampilkan nilai inputan angka pertama dan kedua
        /// </summary>
        public void display_kali()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Hasil Perkalian");
            Console.WriteLine("------------------\n");
            Console.WriteLine("Angka Pertama: " + angka1);
            Console.WriteLine("Angka Kedua: " + angka2);
            Console.WriteLine("Hasil : " + hitung_kali(angka1,angka2) + "\n");
        }
        /// <summary>
        /// Main Program yang bertugas sebagai eksekusi code
        /// </summary
        static void Main(string[] args)
        {
            Program newObj = new Program();


            char pilihan;

            while (true)
            {
                newObj.menu();
                Console.Write("Pilih Menu: ");
                pilihan = Convert.ToChar(Console.ReadLine());

                switch (pilihan)
                {
                    case '1':
                        newObj.input();
                        newObj.display_tambah();
                        break;
                    case '2':
                        newObj.input();
                        newObj.display_kurang();
                        break;
                    case '3':
                        newObj.input();
                        newObj.display_kali();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak tersedia");
                        break;
                }
            }

        }
    }
}
