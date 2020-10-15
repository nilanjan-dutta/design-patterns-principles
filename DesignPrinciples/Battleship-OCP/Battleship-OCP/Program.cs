using Battleship_OCP.Carriers;
using System;
using System.Collections.Generic;

namespace Battleship_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hornet = new USSHornet { TorpedoDamage = 500, TorpedoNumbers = 6, TorpedoSpeed = 300 };
            var enterprise = new Enterprise { TorpedoDamage = 500, TorpedoSpeed = 300 };

            var kaga = new Kaga { TorpedoSpeed = 300 };
            var akagi = new Akagi();

            var launcher = new TorpedoLauncher(new List<CarrierBase> { hornet, enterprise, kaga, akagi });

            launcher.LaunchTorpedos();

            Console.ReadLine();
        }
    }
}
