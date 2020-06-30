using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DoubTech.CastleDefender.AI.Enums;
using UnityEngine.EventSystems;

namespace DoubTech.CastleDefender.AI.Events
{
    public interface AnnounceGameModeEvent : IEventSystemHandler
    {
        void AnnounceGameMode(GameModes mode);
    }

    public interface RequestGameModeEvent : IEventSystemHandler
    {
        void RequestGameMode(GameModes mode);
    }
}
