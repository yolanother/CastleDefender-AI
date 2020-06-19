using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using DoubTech.CastleDefender.AI.Interfaces.States.Stats;

namespace DoubTech.CastleDefender.AI.Interfaces.States
{
    public interface IAttackerInfo
    {
        bool HasAttacker {
            get;
        }

        ITarget[] Attackers {
            get;
        }

        ITarget ClosestAttacker {
            get;
        }

        bool IsAttacker(IUnit unit);

        bool IsFactionAttacking(IFaction faction);
    }
}
