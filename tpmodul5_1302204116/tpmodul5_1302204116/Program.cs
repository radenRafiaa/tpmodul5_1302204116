using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302203122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vid1 = new SayaTubeVideo("Tutorial Design By Contract – RADEN RAFI ALIF AKBAR");
            vid1.PrintVideoDetails();
        }
    }
    class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVideo(string title)
        {
            Random shuffle = new Random();
            this.id = shuffle.Next(0, 100000);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int data)
        {
            this.playCount += data;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Id        : " + this.id);
            Console.WriteLine("Title     : " + this.title);
            Console.WriteLine("PlayCount : " + this.playCount);
        }

    }
}