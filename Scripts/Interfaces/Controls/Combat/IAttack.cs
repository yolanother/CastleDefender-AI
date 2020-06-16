using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.Controls.Combat
{
    public interface IAttack
    {
        float AttackPitch {
            get;
            set;
        }

        float AttackYaw {
            get;
            set;
        }

        /// <summary>
        /// Initiate an attack
        /// 
        /// The attack that is used will be dependent on remaining stamina. If there isn't enough stamina
        /// for a strong attack a weaker attack will be used. If there is no stamina no atack will be performed
        /// </summary>
        /// <param name="strength">Range from 0 to 1 weak->strong. The stronger the attack the more stamina will be used.</param>
        void Attack(float strength);
    }
}
