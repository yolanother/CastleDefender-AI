using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using UnityEngine.Events;

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

        OnUnitDiedEvent OnDeath {
            get;
        }
    }

    [System.Serializable]
    public class OnUnitDiedEvent : UnityEvent<IUnit> { }
}
