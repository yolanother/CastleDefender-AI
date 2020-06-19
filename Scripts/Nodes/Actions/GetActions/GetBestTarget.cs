using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace DoubTech.CastleDefender.AI.Nodes.Conditions.States{
	[Category("Castle Defender/Combat/Target")]
	[Description("Gets the closest target that isn't targeted by someone else in the same Faction.")]
	public class GetBestTarget : ActionTask<IUnit>
	{
		public BBParameter<ITarget> target;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute(){
			target.value = agent.TargetControl.BestPotentialTarget;
			if (null != target.value) {
				EndAction(true);
			} else {
				EndAction(false);
			}
		}
	}
}