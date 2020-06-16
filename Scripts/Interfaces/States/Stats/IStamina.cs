using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.States.Stats
{
    public interface IStamina
    {
        int MaxStamina {
            get;
        }

        int CurrentStamina {
            get;
        }

        float PercentStamina {
            get;
        }
    }
}
