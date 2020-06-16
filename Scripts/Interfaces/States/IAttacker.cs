using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.States
{
    public interface IAttacker
    {
        bool HasAttacker {
            get;
        }

        Vector3[] AttackerPositions {
            get;
        }
    }
}
