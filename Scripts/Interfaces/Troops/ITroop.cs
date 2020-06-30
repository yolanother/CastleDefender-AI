using UnityEngine;
using DoubTech.CastleDefender.AI.Interfaces.Controls;
using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.States.Stats;
using DoubTech.CastleDefender.AI.Interfaces.Units;

namespace DoubTech.CastleDefender.AI.Interfaces.Troops
{
    public enum TroopState
    {
        Attack,
        Retreat,
        HoldFormation
    }
    
    public interface ITroop : IMovable
    {
        IControlPointState ControlPointState
        {
            get;
        }
        
        IFormation Formation
        {
            get;
        }
        
        IFaction Faction {
            get;
        }

        bool AutoRecruitTroops
        {
            get;
            set;
        }

        IUnit[] Units
        {
            get;
        }

        IUnit[] TroopDetectedUnits
        {
            get;
        }

        TroopState TroopState
        {
            get;
            set;
        }

        bool IsAttacking
        {
            get;
        }

        bool IsRetreating
        {
            get;
        }

        bool IsHoldingFormation
        {
            get;
        }

        bool IsTroopFull
        {
            get;
        }

        int TroopSize
        {
            get;
        }

        int TroopCapacity
        {
            get;
            set;
        }

        bool IsTroopUnderAttack
        {
            get;
        }

        bool MoveToFormationBeforeAttacking
        {
            get;
            set;
        }

        IUnit NextAvailableTarget
        {
            get;
        }

        float AverageTroopHealth
        {
            get;
        }

        float PercentOfTroopRemaining
        {
            get;
        }

        void Reset();

        Vector3 StartPosition { get; set; }
        float StartRotation { get; set; }
        Vector3 TroopPosition { get; set; }
        float TroopRotation { get; set; }

        bool BackupUnit(IUnit unit, int backupSize = 0);

        bool AssignUnitToTroopTarget(IUnit unit);

        void AssignUnitToTroop(IUnit unit);

        void RemoveUnitFromTroop(IUnit unit);

        void AssignAllTargets();

        void Attack();

        void Retreat();

        void ReturnToFormation();

        Vector3 GetFormationPoint(IUnit unit);
    }
}
