using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using System;
using UnityEngine;

namespace DoubTech.CastleDefender.AI.Nodes.Actions
{
    public abstract class TargetUnitTask : ActionTask<IUnit>
	{
		[Tooltip("Overrides the unit's current target. If null, the unit's current target will be attacked.")]
		[SerializeField]
		public BBParameter<ITarget> target;

		protected ITarget Target {
			get {
				if (null == this.target.value && null == agent.TargetControl.Target) EndAction(false);
				var target = null != this.target.value ? this.target.value : agent.TargetControl.Target;
				if (target.TargetUnit.Health.IsDead) {
					EndAction(false);
					return null;
				}

				return target;
			}
		}

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return agent.TargetControl.Target == null && target.value == null ? "No target to attack." : null;
		}

		protected sealed override void OnExecute() {
			base.OnExecute();
			var target = Target;
			if(null != target) OnExecuteOnTarget(target);
		}

		protected sealed override void OnUpdate() {
			base.OnUpdate();
			var target = Target;
			if(null != target) {
				OnUpdate(target);
			}
		}

		protected virtual void OnUpdate(ITarget target) {

		}

		protected abstract void OnExecuteOnTarget(ITarget target);
	}
}