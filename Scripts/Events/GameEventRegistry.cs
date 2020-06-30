using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DoubTech.CastleDefender.AI.Enums;
using DoubTech.CastleDefender.CombatSystem.Troops;

namespace DoubTech.CastleDefender.AI.Events
{
    public class GameEventRegistry : MonoBehaviour
    {
        public delegate void OnMatchStartedEvent();
        public delegate void OnMatchEndedEvent();
        
        public delegate Troop GetTroopEvent();
        public delegate GameModes GetGameModeEvent();

        public static GetGameModeEvent GetGameMode;
        public static GetTroopEvent CreateTroop;

        public static OnMatchStartedEvent OnMatchStarted;
        public static OnMatchEndedEvent OnMatchEnded;
    }
}
