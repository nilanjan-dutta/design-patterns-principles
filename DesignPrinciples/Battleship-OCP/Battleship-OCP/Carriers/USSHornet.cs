using System;

namespace Battleship_OCP
{
    internal class USSHornet : CarrierBase
    {
        internal int TorpedoNumbers { get; set; }
        internal int TorpedoSpeed { get; set; }
        internal int TorpedoDamage { get; set; }

        public override void LaunchTorpedo()
        {
            Console.WriteLine($"Launching torpedo for Hornet: Damage: " +
                        $"{TorpedoDamage}, Numbers{TorpedoNumbers}, Speed{TorpedoSpeed}");
        }

    }
}
