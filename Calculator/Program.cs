using System;

namespace Calculator
{
    /// <summary>
    /// Class Program
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            ProgramCalculator newObj = new ProgramCalculator();

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
