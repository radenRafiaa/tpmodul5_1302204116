using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204116
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - RADEN RAFI ALIF AKBAR");
            video1.IncreasePlayCount(412);
            video1.PrintVideoDetails();

            SayaTubeVideo video2 = new SayaTubeVideo("Tutorial Handling Exception - RADEN RAFI ALIF AKBAR");
            video2.IncreasePlayCount(23523532);
            video2.PrintVideoDetails();

            SayaTubeVideo video3 = new SayaTubeVideo("Tutorial Handling Exception - RADEN RAFI ALIF AKBAR RADEN RAFI ALIF AKBAR RADEN RAFI ALIF AKBAR RADEN RAFI ALIF AKBAR RADEN RAFI ALIF AKBAR RADEN RAFI ALIF AKBAR RADEN RAFI ALIF AKBAR");
            video3.IncreasePlayCount(21);
            video3.PrintVideoDetails();

            SayaTubeVideo video4 = new SayaTubeVideo("Tutorial Handling Exception - RADEN RAFI ALIF AKBAR");
            for (int i = 0; i < 215; i++)
            {
                video4.IncreasePlayCount(10000000);
            }
            video4.PrintVideoDetails();
        }
        public SayaTubeVideo(string title)
        {
            Random shuffle = new Random();
            this.id = shuffle.Next(0, 100000);
            this.playCount = 0;

            Debug.Assert(title != null, "Judul video tidak boleh kosong");
            Debug.Assert(title.Length < 100, "Judul video tidak boleh lebih dari 100 karakter");

            string cek;

            try
            {
                cek = checked(title);
                this.title = title;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void IncreasePlayCount(int data)
        {
            Debug.Assert(this.playCount <= int.MaxValue);
            Debug.Assert(data <= 10000000, "Input tidak boleh lebih dari 10 juta karakter");

            int cek;
            try
            {
                cek = checked(this.playCount + data);
                this.playCount += data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                this.playCount = this.playCount;
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Id         : " + this.id);
            Console.WriteLine("Title      : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount + "\n");
        }
    }
}