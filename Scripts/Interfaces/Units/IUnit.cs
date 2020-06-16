using UnityEngine;
using DoubTech.CastleDefender.AI.Interfaces.States.Stats;
using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Controls.Combat;
using DoubTech.CastleDefender.AI.Interfaces.Controls;

namespace DoubTech.CastleDefender.AI.Interfaces.Units
{
    public class IUnit : MonoBehaviour
    {
        #region Stats
        IHealth Health {
            get;
        }

        IStamina Stamina {
            get;
        }
        #endregion

        #region Combat States
        IWeapon Weapon {
            get;
        }

        IAttacker Attacker {
            get;
        }
        #endregion

        #region Controls
        IAttack AttackControl {
            get;
        }

        IBlock BlockControl {
            get;
        }

        IMovement MovementControl {
            get;
        }
        #endregion
    }
}
