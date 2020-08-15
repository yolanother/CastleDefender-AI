using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using DoubTech.CastleDefender.AI.Nodes.Actions;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace DoubTech.CastleDefender.AI.Actions.Combat {

	[Category("Castle Defender/Combat")]
	[Description("Assigns the units target to whatever is currently the best possible target")]
	public class TargetBestPossibleTarget : ActionTask<IUnit> {
		[SerializeField]
		public BBParameter<ITarget> target;

		protected override void OnExecute() {
			base.OnExecute();

			if (agent.TargetControl.BestPotentialTarget == null) EndAction(false);
			else {
				target.value = agent.TargetControl.Target = agent.TargetControl.BestPotentialTarget;
				EndAction(true);
			}
		}
	}
}