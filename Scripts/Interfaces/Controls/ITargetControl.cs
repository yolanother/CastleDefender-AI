using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;

namespace DoubTech.CastleDefender.AI.Interfaces.Controls
{
    public interface ITargetControl
    {
        bool HasTarget {
            get;
        }

        ITarget Target {
            get;
            set;
        }

        ITarget[] PotentialTargets {
            get;
        }

        ITarget BestPotentialTarget {
            get;
        }

        int LayerMask { get; }

        void StopTargeting(ITarget attacker);
        void StopTargeting(IUnit attacker);
        bool WithinAttackDistanceOf(ITarget value);

        bool WithinAttackDistanceOfTarget
        {
            get;
        }

        ITarget GetTarget(IUnit unit);
    }
}
