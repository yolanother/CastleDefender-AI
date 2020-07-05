using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.Navigation
{
    public interface IWaypoints
    {
        Transform RandomWanderWaypoint { get; }
        bool HasPatrolWaypoint { get; }
        bool HasWanderWaypoint { get; }

        Transform NextPatrolWaypoint();
        Transform FirstPatrolWaypoint { get;  }
        Transform CurrentPatrolWaypoint { get; }
    }
}
