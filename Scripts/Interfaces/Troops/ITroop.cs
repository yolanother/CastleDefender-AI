using UnityEngine;
using DoubTech.CastleDefender.AI.Interfaces.Controls;
using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.States.Stats;
using DoubTech.CastleDefender.AI.Interfaces.Units;

namespace DoubTech.CastleDefender.AI.Interfaces.Troops
{
    public interface ITroop
    {
        IMovement Movement
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

        bool IsTroopUnderAttack
        {
            get;
        }

        bool MoveToFormationBeforeAttacking
        {
            get;
            set;
        }

        ITarget NextAvailableTarget
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

        void BackupUnit(IUnit unit, int backupSize = 0);

        void AssignUnitToTroopTarget(IUnit unit);

        void AssignUnitToTroop(IUnit unit);

        void RemoveUnitFromTroop(IUnit unit);

        void AssignAllTargets();

        void Attack();

        void Retreat();

        void ReturnToFormation();

        Vector3 GetFormationPoint(IUnit unit);
    }
}
