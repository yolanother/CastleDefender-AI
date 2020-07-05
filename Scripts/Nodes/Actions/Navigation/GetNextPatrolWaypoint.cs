using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace DoubTech.CastleDefender.AI.Nodes.Actions{

	[Category("Castle Defender/Navigation")]
	[Description("Gets a random waypoint meant for wandering.")]
	public class GetNextPatrolWaypoint : ActionTask<IUnit>{
		public BBParameter<Vector3> waypoint;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute(){
			var value = agent.Waypoints.NextPatrolWaypoint();
			if (value != null) {
				waypoint.value = value.position;
				EndAction(true);
			} else {
				EndAction(false);
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