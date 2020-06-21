using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.Units
{
    public interface IUnitColors
    {
        Color Primary {
            get;
            set;
        }
        Color Secondary {
            get;
            set;
        }
        Color LeatherPrimary {
            get;
            set;
        }
        Color LeatherSecondary {
            get;
            set;
        }
        Color MetalPrimary {
            get;
            set;
        }
        Color MetalSecondary {
            get;
            set;
        }
        Color MetalDark {
            get;
            set;
        }
        Color Hair {
            get;
            set;
        }
        Color Skin {
            get;
            set;
        }
        Color Stubble {
            get;
            set;
        }
        Color Scar {
            get;
            set;
        }
        Color BodyArt {
            get;
            set;
        }
        Color Eyes {
            get;
            set;
        }
    }
}
