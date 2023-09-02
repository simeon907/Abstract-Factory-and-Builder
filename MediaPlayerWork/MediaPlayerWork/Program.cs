using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();

            mediaPlayer.PlayButton();
            mediaPlayer.SwitchButton();
            Console.WriteLine(new string('-', 20));

            mediaPlayer.PlayButton();
            mediaPlayer.PlayButton();
            mediaPlayer.SwitchButton();
            Console.WriteLine(new string('-', 20));

            mediaPlayer.PlayButton();
            mediaPlayer.SwitchButton();
            Console.WriteLine(new string('-', 20));

            Console.WriteLine($"Current state: {mediaPlayer.State.GetType()}");
            Console.ReadKey();
        }
    }
}
