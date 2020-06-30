using DoubTech.CastleDefender.AI.Interfaces.Units;
using NodeCanvas.Framework;
using ParadoxNotion.Design;


namespace DoubTech.CastleDefender.AI.Nodes.Conditions.Troops{

	[Category("Castle Defender/Troops/Unit Control")]
	[Description("Returns true if this unit's troop wants it to attack")]
	public class IsUnitTroopAttacking : ConditionTask<IUnit>{

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null != agent.Troop ? null : "Unit is not part of a troop.";
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable(){
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable(){
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck(){
			return agent.Troop.IsAttacking;
		}
	}
}