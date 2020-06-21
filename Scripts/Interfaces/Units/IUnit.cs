using UnityEngine;
using DoubTech.CastleDefender.AI.Interfaces.States.Stats;
using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Controls.Combat;
using DoubTech.CastleDefender.AI.Interfaces.Controls;

namespace DoubTech.CastleDefender.AI.Interfaces.Units
{
    public interface IUnit {
        #region Stats
        string Name {
            get;
        }

        IHealth Health {
            get;
        }

        IStamina Stamina {
            get;
        }

        IFaction Faction {
            get;
        }

        ITroop Troop {
            get;
        }
        #endregion

        #region Combat States
        IWeapon Weapon {
            get;
        }

        IAttackerInfo Attacker {
            get;
        }

        bool IsActive {
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

        ITargetControl TargetControl {
            get;
        }

        #endregion

        GameObject GameObject {
            get;
        }

        IUnitColors Colors {
            get;
        }
    }
}
