using DoubTech.CastleDefender.AI.Enums;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace DoubTech.CastleDefender.AI.Nodes.Actions{

	[Category("Castle Defender/Navigation")]
	[Description("Causes the unit to wander around the map")]
	public class Wander : ActionTask<IUnit>
    {
        public BBParameter<MovementSpeed> speed = MovementSpeed.Run;
        [Range(0, 1)]
        public BBParameter<float> customSpeed = 1;
        public BBParameter<float> keepDistance = 0.1f;
        public BBParameter<float> minWanderDistance = 5;
        public BBParameter<float> maxWanderDistance = 20;
        public bool repeat = true;

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
            DoWander();
        }

        protected override void OnUpdate() {
            if (!agent.MovementControl.LookingForPath && agent.MovementControl.DistanceToMoveTarget <= agent.MovementControl.StoppingDistance + keepDistance.value) {
                if (repeat) {
                    DoWander();
                } else {
                    EndAction();
                }
            }
        }

        void DoWander() {
            var min = minWanderDistance.value;
            var max = maxWanderDistance.value;
            min = Mathf.Clamp(min, 0.01f, max);
            max = Mathf.Clamp(max, min, max);
            var position = agent.MovementControl.Position;
            var wanderPos = position;
            while ((wanderPos - position).sqrMagnitude < min) {
                wanderPos = (Random.insideUnitSphere * max) + position;
            }

            NavMeshHit hit;
            if (NavMesh.SamplePosition(wanderPos, out hit, float.PositiveInfinity, NavMesh.AllAreas)) {
                agent.MovementControl.MoveTo(hit.position);
            }
        }

        protected override void OnPause() { OnStop(); }
        protected override void OnStop() {
            if (agent != null && agent.IsActive) {
                agent.MovementControl.Stop();
            }
        }
    }
}