using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_090
{
    

    class List
    {
        int[] arr = new int[10];
        string[] str = new string[20];

        public int id_barang;
        public string nama_barang;
        public string jenis_barang;
        public int harga_barang;
        

        public void input()
        {
            int id;
            string nm;
            string jns;
            int hrg;

            Console.WriteLine("\nMasukkan ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMasukkan Nama Barang : ");
            nm = Console.ReadLine();
            Console.WriteLine("\nMasukkan Jenis Barang : ");
            jns = Console.ReadLine();
            Console.WriteLine("\nMasukkan harga barang : ");
            hrg = Convert.ToInt32(Console.ReadLine());



        }

        


    }
   
    class Program
    {
        
        

        static void Main(string[] args)
        {

        }
    }
}




// Soal 2
// Menggunakan array karena data masih acak dan belum urut
// Menggunakan binary search karena data yang ada di toko pasti banyank dan untuk efisiensi waktu ketika mencari data 
// Menggunakan Quick Sort


// Soal 3
// Array digunakan ketika data belum berurutan
// Linked List digunakan ketika data sudah urut 

//Soal 4
// data dapat ditambakan diakhir disebut REAR
// data dihapus dari yang paling akhir disebut FRONT 

// Soal 5

// Bagian A
// 42 gaada sibling
// 62 mempunyai sibling 64
// 25 gaada sibling
// 46 mempunyai sibling 55
// 63 mempunyai sibling 70
// 18 mempunyai 53 
// 65 gaada sibling
// 41 mempunyai 74


// Bagian B
// Cara baca struktur pohon menggunakan inOrder yaitu dimulai dari subtree paling kiri :
//16, 25, 41, 42, 46, 53, 55, 60, 62, 63, 64, 65, 70, 74

