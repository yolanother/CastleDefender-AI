using UnityEngine;
using DoubTech.CastleDefender.AI.Enums;
using DoubTech.CastleDefender.AI.Interfaces.Controls;
using NodeCanvas.Framework;

namespace DoubTech.CastleDefender.AI.Navigation
{
    public abstract class BaseMovementTask<T> : ActionTask<T> where T : class, IMovable 
    {
        public BBParameter<MovementSpeed> speed = MovementSpeed.Run;
        [Range(0, 1)]
        public BBParameter<float> customSpeed = 1;
        public BBParameter<float> keepDistance = 0.1f;

        protected abstract Vector3 Position
        {
            get;
        }

        protected override void OnExecute() {
            switch (speed.value) {
                case MovementSpeed.Run:
                    agent.MovementControl.Speed = 1;
                    break;
                case MovementSpeed.Walk:
                    agent.MovementControl.Speed = 0.5f;
                    break;
                case MovementSpeed.Custom:
                    agent.MovementControl.Speed = customSpeed.value;
                    break;
            }
            DoSeek();
        }

        protected override void OnUpdate() {
            if (!agent.MovementControl.LookingForPath && agent.MovementControl.DistanceToMoveTarget <= agent.MovementControl.StoppingDistance + keepDistance.value) {
                EndAction();
            }
        }

        void DoSeek() {
            agent.MovementControl.MoveTo(Position);
        }

        protected override void OnPause() { OnStop(); }
        protected override void OnStop() {
            if (agent != null && agent.IsActive) {
                agent.MovementControl.Stop();
            }
        }
    }
}
