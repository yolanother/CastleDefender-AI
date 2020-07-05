using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DoubTech.CastleDefender.AI.Interfaces.Units;

namespace DoubTech.CastleDefender.AI.Interfaces.States
{
    public interface ITarget
    {
        IUnit TargetUnit {
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

        /// <summary>
        /// Returns the last known closest attack position relative to the target. To get the actual position
        /// you should add this position to the targets current position.
        /// 
        /// NOTE: This should be recalculated on demand ratelimited to once per half second.
        /// </summary>
        Vector3[] NearestRelativeAttackPositions {
            get;
        }

        /// <summary>
        /// Returns the last known closest attack position to the target.
        /// 
        /// NOTE: This should be recalculated on demand ratelimited to once per half second.
        /// </summary>
        Vector3[] NearestAttackPositions {
            get;
        }
    }
}
