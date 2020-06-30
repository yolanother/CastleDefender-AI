using DoubTech.CastleDefender.AI.Enums;
using DoubTech.CastleDefender.AI.Interfaces.States;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using DoubTech.CastleDefender.AI.Navigation;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace DoubTech.CastleDefender.AI.Nodes.Actions.Troops.UnitControl{

	[Category("Castle Defender/Troops/Unit Control")]
	[Description("Causes the unit to move to their position in a troop formation")]
	public class MoveToFormation : BaseMovementTask<IUnit>
	{
		protected override string OnInit()
		{
			return agent.Troop == null ? agent.Name + " has not been assigned to a troop." : null;
		}

		protected override Vector3 Position => agent.Troop.MovementControl.Position + agent.Troop.GetFormationPoint(agent);
	}
}