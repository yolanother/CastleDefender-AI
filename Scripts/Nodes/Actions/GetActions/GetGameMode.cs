using DoubTech.CastleDefender.AI.Enums;
using DoubTech.CastleDefender.AI.Events;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace DoubTech.CastleDefender.AI.Nodes.Actions.Troops{

	[Category("Castle Defender/Game Play")]
	[Description("Returns the current game mode")]
	public class GetGameMode : ActionTask<GameObject>
	{
		public BBParameter<GameModes> gameMode;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null == GameEventRegistry.GetGameMode ? "Event registry has not been set up to get game modes." : null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute()
		{
			gameMode.value = GameEventRegistry.GetGameMode();

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