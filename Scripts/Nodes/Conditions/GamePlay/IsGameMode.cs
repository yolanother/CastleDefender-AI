using DoubTech.CastleDefender.AI.Enums;
using DoubTech.CastleDefender.AI.Events;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace DoubTech.CastleDefender.AI.Nodes.Conditions.GamePlay{

	[Category("Castle Defender/Game Play")]
	[Description("Checks if the provided game mode is the current game mode")]
	public class IsGameMode : ConditionTask
	{
		[RequiredField] public BBParameter<GameModes> gameMode;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null == GameEventRegistry.GetGameMode ? "Event registry has not been set up to get game modes." : null;
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck(){
			Debug.Log("AARON: Game mode: " + GameEventRegistry.GetGameMode() + "==" + gameMode.value);
			return gameMode.value == GameEventRegistry.GetGameMode();
		}
	}
}