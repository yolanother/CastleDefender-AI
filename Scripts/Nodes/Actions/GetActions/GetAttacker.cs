using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace DoubTech.CastleDefender.AI.Nodes.Conditions.States{

	[Category("Castle Defender/Combat/Target")]
	[Description("Gets the current closest attacker")]
	public class GetAttacker : ActionTask<IUnit>{
		BBParameter<ITarget> target;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute(){
			if (!agent.Attacker.HasAttacker) EndAction(false);
			else {
				target.value = agent.Attacker.ClosestAttacker;
				EndAction(true);
			}
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate(){
			
		}

		//Called when the task is disabled.
		protected override void OnStop(){
			
		}

		//Called when the task is paused.
		protected override void OnPause(){
			
		}
	}
}