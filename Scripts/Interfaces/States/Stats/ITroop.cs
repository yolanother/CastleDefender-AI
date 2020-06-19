using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.States.Stats
{
    public interface ITroop
    {
        IFaction Faction {
            get;
        }
    }
}
