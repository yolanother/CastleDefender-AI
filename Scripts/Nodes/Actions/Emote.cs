using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace DoubTech.CastleDefender.AI.Nodes.Conditions.States{

	[Category("Castle Defender/Character Actions")]
	[Description("Plays a non-combat emote like a battle cry or taunt.")]
	public class Emote : ActionTask<IUnit>
	{
		public BBParameter<string> emoteName;
		[Range(0, 1)]
		public BBParameter<float> chanceToEmote = 1;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null == emoteName ? "You must provide an emote name." : null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			if (Random.Range(0, 1f) <= chanceToEmote.value) {
				agent.EmoteControl.Emote(emoteName.value, success => EndAction(success));
			}
		}
	}
}