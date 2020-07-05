using UnityEngine;
using DoubTech.CastleDefender.AI.Interfaces.States.Stats;
using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Controls.Combat;
using DoubTech.CastleDefender.AI.Interfaces.Controls;
using DoubTech.CastleDefender.AI.Interfaces.Troops;
using DoubTech.CastleDefender.AI.Interfaces.Navigation;

namespace DoubTech.CastleDefender.AI.Interfaces.Units
{
    public interface IUnit : IMovable {
        #region Stats

        int Id {
            get;
        }

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
            set;
        }
        #endregion

        #region Combat States
        IWeapon Weapon {
            get;
        }

        IAttackerInfo AttackerInfo {
            get;
        }

        bool IsActive {
            get;
        }

        IControlPointState ControlPointState
        {
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

        IEmoteControl EmoteControl {
            get;
        }

        #endregion

        #region Objectives
        IWaypoints Waypoints {
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
