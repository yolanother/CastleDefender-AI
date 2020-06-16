using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.States
{
    public interface IWeapon
    {
        float MinAttackDistance {
            get;
        }

        float MaxAttackDistance {
            get;
        }

        float BestAttackDistance {
            get;
        }

        /// <summary>
        /// Gets the stamina cost of an attack at the given strength with the currently equipped weapon
        /// </summary>
        /// <param name="strength"></param>
        /// <returns></returns>
        int GetStaminaCost(float strength);
    }
}