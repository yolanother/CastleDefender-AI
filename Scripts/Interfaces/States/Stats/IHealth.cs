using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.States.Stats
{
    public interface IHealth
    {
        float HealthPercent {
            get;
        }

        int CurrentHealth {
            get;
        }

        int MaxHealth {
            get;
        }

        bool IsAlive {
            get;
        }

        bool IsDead {
            get;
        }
    }
}
