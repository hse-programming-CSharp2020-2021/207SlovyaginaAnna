using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_skrin
{
    public class PlayIsStartedEventArgs : EventArgs
    {
        public int SoundNumber { get; set; }
        public PlayIsStartedEventArgs(int number)
        {
            SoundNumber = number;
        }

    }
    class BandMaster
    {
        public event EventHandler<PlayIsStartedEventArgs> ev;
        static Random random = new Random();
        public void StartPlay()
        {
            int n = random.Next(2, 6);
            ev?.Invoke(this,
                new PlayIsStartedEventArgs(n));
        }
    }
    public abstract class OrchestraPlayer
    {
        public string Name { get; set; }
        public abstract void PlayIsStartedEventHandler(object sender, PlayIsStartedEventArgs e);
    }
    class Violinist : OrchestraPlayer
    {
        public override void PlayIsStartedEventHandler(object sender, PlayIsStartedEventArgs e)
        {
            Console.WriteLine($"Violinist {Name} plays composition {e.SoundNumber}: Du-du");
        }
    }
    class Hornist : OrchestraPlayer
    {
        public override void PlayIsStartedEventHandler(object sender, PlayIsStartedEventArgs e)
        {
            Console.WriteLine($"Hornnist {Name} plays composition {e.SoundNumber}: La-la");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BandMaster master = new BandMaster();
            Random random = new Random();
            OrchestraPlayer[] orc = new OrchestraPlayer[10];
            for (int i = 0; i < orc.Length; i++)
            {
                int n = random.Next(0, 2);
                if (n == 0)
                    orc[i] = new Violinist() { Name = random.Next(100, 200).ToString() };
                else
                    orc[i] = new Hornist() { Name = random.Next(100, 200).ToString() };
                master.ev += orc[i].PlayIsStartedEventHandler;
            }
            int k = 3;
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("*****");
                master.StartPlay();
            }
        }
    }
}