using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.Controls.Combat
{
    public delegate void OnAttackComplete(bool success);

    public interface IAttack
    {
        bool UseRandomPitch {
            get;
            set;
        }

        bool UseRandomYaw {
            get;
            set;
        }

        float AttackPitch {
            get;
            set;
        }

        float AttackYaw {
            get;
            set;
        }

        /// <summary>
        /// Initiate a random attack with the given strength
        /// 
        /// The attack that is used will be dependent on remaining stamina. If there isn't enough stamina
        /// for a strong attack a weaker attack will be used. If there is no stamina no atack will be performed
        /// </summary>
        /// <param name="strength">Range from 0 to 1 weak->strong. The stronger the attack the more stamina will be used.</param>
        /// <returns>Returns true if attack started successfully</returns>
        bool Attack(float strength, OnAttackComplete attackComplete);

        /// <summary>
        /// Start an attack by name. The attack animation will begin and the animation will control how strong the attack is.
        /// </summary>
        /// <param name="attackName"></param>
        /// <param name="attackComplete"></param>
        /// <returns>Returns true if attack started successfully</returns>
        bool Attack(string attackName, OnAttackComplete attackComplete);
    }
}
