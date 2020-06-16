using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.States
{
    public interface ITarget
    {
        bool HasTarget {
            get;
        }

        bool TargetedByFriendly {
            get;
        }

        Vector3 TargetPosition {
            get;
        }

        Vector3[] TargetAttackPositions {
            get;
        }

        Vector3 RandomOpenTargetAttackPosition {
            get;
        }

        Vector3 NearestOpenTargetAttackPosition {
            get;
        }
    }
}
