using DoubTech.CastleDefender.AI.Enums;
using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace DoubTech.CastleDefender.AI.Nodes.Actions{

	[Category("Castle Defender/Navigation")]
	[Description("Causes the unit to move into an open attack position around the target")]
	public class MoveToAttackPosition : ActionTask<IUnit>
    {
        public BBParameter<ITarget> target;
        public BBParameter<MovementSpeed> speed = MovementSpeed.Run;
        [Range(0, 1)]
        public BBParameter<float> customSpeed = 1;
        public BBParameter<float> keepDistance = 0.1f;
        public BBParameter<float> targetPositionReadjustThreashold = 2;
        private Vector3 targetPosition;

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
            if (target.value.TargetUnit.Health.IsDead) {
                EndAction(false);
            } else if (agent.TargetControl.WithinAttackDistanceOf(target.value)) {
                EndAction(true);
            } else if (!agent.MovementControl.LookingForPath && agent.MovementControl.DistanceToMoveTarget <= agent.MovementControl.StoppingDistance + keepDistance.value) {
                EndAction(true);
            } else {
                DoSeek();
            }
        }

        void DoSeek() {
            NavMeshHit hit;
            targetPosition = target.value.TargetPosition;
            var movePos = target.value.NearestOpenTargetAttackPosition;
            if(float.IsInfinity(movePos.x)) {
                Debug.Log(target.name + " has no open attack points. Target is no longer valid.");
                agent.TargetControl.Target = null;
                EndAction(false);
            } else if (agent.MovementControl.MoveTo(movePos)) {
                agent.MovementControl.RotateTowards(target.value);
            } else {
                EndAction(agent.TargetControl.WithinAttackDistanceOf(target.value));
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