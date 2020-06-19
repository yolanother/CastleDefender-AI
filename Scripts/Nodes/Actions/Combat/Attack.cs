using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace DoubTech.CastleDefender.AI.Actions.Combat {

	[Category("Castle Defender/Combat")]
	[Description("Attempts to trigger an attack at the desired strength")]
	public class Attack : ActionTask<IUnit>{
		[SerializeField]
		public BBParameter<ITarget> target;
		[SerializeField]
		public BBParameter<bool> useRandomStrength = false;
		[SerializeField]
		public BBParameter<float> strength = 0.5f;
		[SerializeField]
		public BBParameter<string> attackName = null;

		private bool attackComplete;
		private bool attackSuccess;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return target.value == null ? "No target to attack." : null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute(){
			var s = strength.value;
			if(useRandomStrength.value) {
				s = Random.Range(0, 1.0f);
			}
			attackComplete = false;
			attackSuccess = false;

			if (null != attackName.value) {
				if (!agent.AttackControl.Attack(attackName.value, CompleteAttack)) {
					CompleteAttack(false);
				}
			} else if (!agent.AttackControl.Attack(s, CompleteAttack)) {
				CompleteAttack(false);
			}

			if (null != target.value) {
				agent.MovementControl.RotateTowards(target.value.TargetPosition);
			}
		}

		private void CompleteAttack(bool success) {
			EndAction(success);
		}
	}
}