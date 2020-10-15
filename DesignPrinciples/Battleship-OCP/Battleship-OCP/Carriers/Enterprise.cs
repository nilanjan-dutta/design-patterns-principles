using System;

namespace Battleship_OCP
{
    internal class Enterprise : CarrierBase
    {        
        internal int TorpedoSpeed { get; set; }
        internal int TorpedoDamage { get; set; }

        public override void LaunchTorpedo()
        {
            Console.WriteLine($"Launching torpedo for Enterprise: Damage: " +
                        $"{TorpedoDamage}, Numbers: {5}, Speed: {TorpedoSpeed}");
        }
    }
}
