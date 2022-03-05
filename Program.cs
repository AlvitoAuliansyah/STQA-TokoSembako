/*

BEGIN
    //Deklarasi Variable
    Numeric nBeras, nMinyak, nTelur, nSusu, nGula, nGaram, nGas, nGasRefill, nTotalBeras, nTotalMinyak, nTotalTelur, nTotalSusu, nTotalGula, nTotalGaram, nTotalGas, nTotalGasRefill;
    //Input
    display “Masukkan harga Beras:”
    accept nBeras
    display “Masukkan harga Minyak:"
    accept nMinyak
    display “Masukkan harga Telur:"
    accept nTelur
    display “Masukkan harga Susu:"
    accept nSusu
    display “Masukkan harga Gula:"
    accept nGula
    display “Masukkan harga Garam:"
    accept nGaram
    display “Masukkan harga Gas:"
    accept nGas
    display “Masukkan harga GasRefill:"
    accept nGasRefill
    display “Masukkan jumlah Beras:”
    accept nTotalBeras
    display “Masukkan jumlah Minyak:"
    accept nTotalMinyak
    display “Masukkan jumlah Telur:"
    accept nTotalTelur
    display “Masukkan jumlah Susu:"
    accept nTotalSusu
    display “Masukkan jumlah Gula:"
    accept nTotalGula
    display “Masukkan jumlah Garam:"
    accept nTotalGaram
    display “Masukkan jumlah Gas:"
    accept nTotalGas
    display “Masukkan jumlah GasRefill:"
    accept nTotalGasRefill
    //Menghitung Total Belanja
    compute Total Belanja = (nTotalBeras x 14.500) + (nTotalMinyak x 15.000) + (nTotalTelur x 22.000) + (nTotalSusu x 18.500) + (nTotalGula x 12.500) + (nTotalGaram x 13.000) + (nTotalGas x 145.000) + (nTotalGasRefill x 22.000)
    //Display Output
    display “Total Kg Beras: ” + nTotalBeras
    display “Total Liter Minyak: ” + nTotalMinyak
    display “Total Kg Telur: ” + nTotalTelur
    display “Total Liter Susu: ” + nTotalSusu
    display “Total Kg Gula: ” + nTotalGula
    display “Total Kg Garam: ” + nTotalGaram
    display “Total Buah Gas 3Kg Baru” + nTotalGas
    display “Total Buah Gas 3Kg Refill: “ + nTotalGasRefill
    display “Total Belanja = “
END
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sembako
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remaks>class Sembako dapat membeli barang sembako dan menghitung total semua harga barang </remarks>

    class Program
    {
        /// <summary>
        /// class Program untuk menghitung total harga barang
        /// </summary>
        
        public double Beras, Minyak, Telur, Susu, Gula, Garam, Gas, GasRefill, TotalBeras, TotalMinyak, TotalTelur, TotalSusu, TotalGula, TotalGaram, TotalGas, TotalGasRefill;
        public List<double> harga = new List<double>();
        int pilih;

        public void HitungBeras()
        {
            Console.WriteLine("Berapa kilogram Beras yang ingin anda beli ?");
            Beras = Double.Parse(Console.ReadLine());
            TotalBeras = Beras * 14500;
            harga.Add(TotalBeras);
            Console.WriteLine("\nBerhasil menambahkan Beras sebanyak: {0} Kg kedalam keranjang \n", Beras);
        }

        public void HitungMinyak()
        {
            Console.WriteLine("Berapa liter Minyak yang ingin anda beli ?");
            Minyak = Double.Parse(Console.ReadLine());
            TotalMinyak = Minyak * 15000;
            harga.Add(TotalMinyak);
            Console.WriteLine("\nBerhasil menambahkan Minyak sebanyak: {0} Liter kedalam keranjang  \n", Minyak);
        }

        public void HitungTelur()
        {
            Console.WriteLine("Berapa kilogram Telur yang ingin anda beli ?");
            Telur = Double.Parse(Console.ReadLine());
            TotalTelur = Telur * 22000;
            harga.Add(TotalTelur);
            Console.WriteLine("\nBerhasil menambahkan Telur sebanyak: {0} Kg kedalam keranjang \n", Telur);
        }

        public void HitungSusu()
        {
            Console.WriteLine("Berapa liter Susu yang ingin anda beli ?");
            Susu = Double.Parse(Console.ReadLine());
            TotalSusu = Susu * 18500;
            harga.Add(TotalSusu);
            Console.WriteLine("\nBerhasil menambahkan Susu sebanyak: {0} Liter kedalam keranjang \n", Susu);
        }

        public void HitungGula()
        {
            Console.WriteLine("Berapa kilogram Gula yang ingin anda beli ?");
            Gula = Double.Parse(Console.ReadLine());
            TotalGula = Gula * 12500;
            harga.Add(TotalGula);
            Console.WriteLine("\nBerhasil menambahkan Gula sebanyak: {0} Kg kedalam keranjang \n", Gula);
        }

        public void HitungGaram()
        {
            Console.WriteLine("Berapa kilogram Garam yang ingin anda beli ?");
            Garam = Double.Parse(Console.ReadLine());
            TotalGaram = Garam * 13000;
            harga.Add(TotalGaram);
            Console.WriteLine("\nBerhasil menambahkan Garam sebanyak: {0} Kg kedalam keranjang \n", Garam);
        }

        public void HitungGas()
        {
            Console.WriteLine("Berapa buah Gas 3Kg Baru yang ingin anda beli ?");
            Gas = Double.Parse(Console.ReadLine());
            TotalGas = Gas * 145000;
            harga.Add(TotalGas);
            Console.WriteLine("\nBerhasil menambahkan Gas sebanyak: {0} Buah kedalam keranjang \n", Gas);
        }

        public void HitungGasRefill()
        {
            Console.WriteLine("Berapa buah Gas 3Kg Refill yang ingin anda beli ?");
            GasRefill = Double.Parse(Console.ReadLine());
            TotalGasRefill = GasRefill * 22000;
            harga.Add(TotalGasRefill);
            Console.WriteLine("\nBerhasil menambahkan GasRefill sebanyak: {0} Buah kedalam keranjang \n", GasRefill);
        }
        
        /// <summary>
        /// method Menu untuk tampilan toko sembako
        /// </summary>
        public void Menu()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("==================================================");
                    Console.WriteLine("===============  Menu Vit Sembako  ===============");
                    Console.WriteLine("==================================================");
                    Console.WriteLine("== 1. Beras                    Rp. 14.500/Kg    ==" +
                        "\n== 2. Minyak Goreng            Rp. 15.000/L     ==" +
                        "\n== 3. Telur                    Rp. 22.000/Kg    ==" +
                        "\n== 4. Susu HUT                 Rp. 18.500/L     ==" +
                        "\n== 5. Gula                     Rp. 12.500/Kg    ==" +
                        "\n== 6. Garam                    Rp. 13.000/Kg    ==" +
                        "\n== 7. Gas 3Kg Baru             Rp. 145.000/Buah ==" +
                        "\n== 8. Gas 3Kg Refill           Rp. 22.000/Buah  ==" +
                        "\n==================================================" +
                        "\n== 9. Selesai dan Keluar Aplikasi               ==");
                    Console.WriteLine("==================================================");
                    Console.Write("Pilihan (1/2/3/4/5/6/7/8/9) : ");
                    pilih = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    switch (pilih)
                    {
                        case 1:
                            HitungBeras();
                            break;
                        case 2:
                            HitungMinyak();
                            break;
                        case 3:
                            HitungTelur();
                            break;
                        case 4:
                            HitungSusu();
                            break;
                        case 5:
                            HitungGula();
                            break;
                        case 6:
                            HitungGaram();
                            break;
                        case 7:
                            HitungGas();
                            break;
                        case 8:
                            HitungGasRefill();
                            break;
                        case 9:
                            if (!harga.Any())
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("List Belanja" +
                                    "\n--------------------------------------------------" +
                                    "\n {0} Kg Beras" +
                                    "\n {1} Liter Minyak" +
                                    "\n {2} Kg Telur" +
                                    "\n {3} Liter Susu" +
                                    "\n {4} Kg Gula" +
                                    "\n {5} Kg Garam" +
                                    "\n {6} Buah Gas 3Kg Baru" +
                                    "\n {7} Buah Gas 3Kg Refill"
                                    , Beras, Minyak, Telur, Susu, Gula, Garam, Gas, GasRefill);
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("Total Belanja = Rp. {0}\n", harga.Sum(x => x));
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("Apakah Masih Ingin Berbelanja?\n" +
                                    "Tekan 'Iya' Untuk Melanjutkan Belanja atau Tekan 'Apa Saja' Untuk Keluar");

                                
                                if (!Console.ReadLine().Equals("Iya", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    harga.Clear();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("\n````````````````````````````````````````````````````````\n");
                                    break;
                                }
                            }
                        default:
                            Console.WriteLine("Pilihan tidak tersedia");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Harap Memasukkan Angka 1 - 9\n");
                }
            }
        }
        
        /// <summary>
        /// method Main
        /// </summary>
        /// <param> name ="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("==================================================" +
                "\n== Selamat Datang di Aplikasi Vit Sembako       ==" +
                "\n== Silahkan Memilih Barang Pada Menu Pembelian  ==" +
                "\n==================================================" +
                "\n ");
            p.Menu(); // Memanggil method menu
        }
    }
}
