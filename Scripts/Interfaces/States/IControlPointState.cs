using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.States
{
    public interface IControlPointState
    {
        Vector3 NextControlPointPosition
        {
            get;
        }
    }
}
