using System;

namespace Battleship_OCP.Carriers
{
    internal class Kaga : CarrierBase
    {
        public int TorpedoSpeed { get; set; }

        public override void LaunchTorpedo()
        {
            Console.WriteLine($"Launching torpedo for Kaga: Damage: " +
                        $"{600}, Numbers: {10}, Speed: {TorpedoSpeed}");
        }
    }
}
