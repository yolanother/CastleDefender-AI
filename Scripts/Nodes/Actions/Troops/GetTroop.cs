using DoubTech.CastleDefender.AI.Interfaces.Troops;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace DoubTech.CastleDefender.AI.Nodes.Actions.Troops{

	[Category("Castle Defender/Troops")]
	[Description("Asks the troop for backup units to help with a target")]
	public class GetTroop : ActionTask<IUnit>
	{
		private BBParameter<ITroop> troop;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null != agent.Troop ? null : "Unit is not part of a troop.";
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute()
		{
			troop.value = agent.Troop;
			EndAction(true);
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