using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DoubTech.CastleDefender.CombatSystem.Interfaces;
using DoubTech.CastleDefender.AI.Interfaces.Units;

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

        string WeaponType { get; }

        /// <summary>
        /// Gets the stamina cost of an attack at the given strength with the currently equipped weapon
        /// </summary>
        /// <param name="strength"></param>
        /// <returns></returns>
        int GetStaminaCost(float strength);

        IUnit WeaponOwner {
            get;
        }
    }
}
