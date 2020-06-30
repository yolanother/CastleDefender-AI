using DoubTech.CastleDefender.AI.Interfaces.Troops;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace DoubTech.CastleDefender.AI.Nodes.Actions.Troops{

	[Category("Castle Defender/Troops")]
	[Description("Returns true if the troop is full")]
	public class GetNextControlPoint : ActionTask<ITroop>
	{
		public BBParameter<Vector3> position;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			if (null == position)
			{
				return "Position must be set to an output variable.";
			}
			return null == agent.ControlPointState ? "There are no control points set up." : null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute()
		{
			position.value = agent.ControlPointState.NextControlPointPosition;
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