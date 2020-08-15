using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using DoubTech.CastleDefender.AI.Nodes.Actions;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace DoubTech.CastleDefender.AI.Actions.Combat {

	[Category("Castle Defender/Combat")]
	[Description("Attempts to trigger an attack at the desired strength")]
	public class Attack : TargetUnitTask {
		[SerializeField]
		public BBParameter<bool> useRandomStrength = true;
		[SerializeField]
		public BBParameter<float> strength = 0.5f;
		[SerializeField]
		public BBParameter<string> attackName = null;

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecuteOnTarget(ITarget target) {
			var s = strength.value;
			if(useRandomStrength.value) {
				s = Random.Range(0, 1.0f);
			}

			if (null != attackName.value) {
				if (!agent.AttackControl.Attack(attackName.value, CompleteAttack)) {
					CompleteAttack(false);
				}
			} else if (!agent.AttackControl.Attack(s, CompleteAttack)) {
				CompleteAttack(false);
			}

			agent.MovementControl.RotateTowards(target.TargetPosition);
		}

		private void CompleteAttack(bool success) {
			EndAction(success);
		}
	}
}