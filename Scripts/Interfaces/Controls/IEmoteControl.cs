using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace DoubTech.CastleDefender.AI.Interfaces.Controls
{
    public interface IEmoteControl
    {
        void Emote(string name, Action<bool> emoteComplete = null);
    }
}
