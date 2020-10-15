using Battleship_OCP.Carriers;
using System;
using System.Collections.Generic;

namespace Battleship_OCP
{
    internal class TorpedoLauncher
    {
        readonly List<CarrierBase> _battleships = null;

        internal TorpedoLauncher(List<CarrierBase> carrierShips)
        {
            _battleships = carrierShips;
        }
        internal void LaunchTorpedos()
        {
            foreach (var carrier in _battleships)
            {
                carrier.LaunchTorpedo();
            }
        }
    }
}
