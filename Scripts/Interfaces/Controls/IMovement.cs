using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DoubTech.CastleDefender.AI.Interfaces.Controls
{
    public interface IMovement
    {
        /// <summary>
        /// Is the unit crouched
        /// </summary>
        bool IsCrouched {
            get;
            set;
        }

        /// <summary>
        /// Is the unit grounded
        /// </summary>
        bool IsGrounded {
            get;
        }

        /// <summary>
        /// Returns the angular rotation speed or sets the target rotation speed
        /// Range -1 -> 1
        /// 
        /// </summary>
        float TurnSpeed {
            get;
            set;
        }

        /// <summary>
        /// Returns the current speed or sets the target speed in the horizontal strafe direction
        /// Range -1 -> 1
        /// </summary>
        float StrafeSpeed {
            get;
            set;
        }

        /// <summary>
        /// Returns the current speed or sets the target speed in the forward direction
        /// Range
        ///   0 -> 0.5 Forwards walking
        ///   0.5 -> 1 Forwards running
        ///   0 -> -0.5 Backwards walking
        ///   -.5 -> -1 Backwards running
        /// </summary>
        float Speed {
            get;
            set;
        }

        /// <summary>
        /// Gets the current bearing or sets the target bearing
        /// </summary>
        float Bearing {
            get;
            set;
        }

        Vector3 Position {
            get;
        }

        Vector3 Velocity {
            get;
        }
        bool LookingForPath { get; }
        float DistanceToMoveTarget { get; }
        float StoppingDistance { get; }
        Vector3 Forward { get; }
        Vector3 Right { get; }

        void Jump();

        void Dodge(float direction);

        void Duck();

        void MoveTo(Vector3 position);
        
        void RotateTowards(Vector3 position);

        void StopRotatingTowards();

        void Stop();

        /// <summary>
        /// Roate the unit by angle degrees
        /// </summary>
        /// <param name="angle">Angle to rotate in degrees</param>
        void Rotate(float angle);
    }
}
