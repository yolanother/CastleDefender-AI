using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace DoubTech.CastleDefender.AI.Nodes.Conditions.States
{

	[Category("Castle Defender/Combat/Target")]
	[Description("Returns true if the agent has a target")]
	public class HasPotentialTarget : ConditionTask<IUnit>
	{
		[SerializeField]
		BBParameter<ITarget> target;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {

		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {

		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			target.value = agent.TargetControl.BestPotentialTarget;
			return null != target.value;
		}
	}
}