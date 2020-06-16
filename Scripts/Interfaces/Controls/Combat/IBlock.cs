using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.Controls.Combat
{
    public interface IBlock
    {
        float BlockPitch {
            get;
            set;
        }

        float BlockYaw {
            get;
            set;
        }

        bool Block {
            get;
            set;
        }

        void QuickBlock();
    }
}
