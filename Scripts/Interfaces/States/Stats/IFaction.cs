using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.States.Stats
{
    public interface IFaction
    {
        string Name {
            get;
        }

        Color PrimaryColor {
            get;
        }

        Color SecondaryColor {
            get;
        }
    }
}
