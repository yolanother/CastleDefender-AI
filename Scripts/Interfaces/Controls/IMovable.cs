using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.Controls
{
    public interface IMovable
    {
        IMovement MovementControl
        {
            get;
        }

        bool IsActive { get; }
    }
}
