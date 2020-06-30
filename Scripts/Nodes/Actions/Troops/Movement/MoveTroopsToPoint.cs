using DoubTech.CastleDefender.AI.Interfaces.Troops;
using DoubTech.CastleDefender.AI.Interfaces.Units;
using DoubTech.CastleDefender.AI.Navigation;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace DoubTech.CastleDefender.AI.Nodes.Actions.Troops{

	[Category("Castle Defender/Troops/Movement")]
	[Description("Moves the troop formation to the specified position")]
	public class MoveTroopsToPoint : BaseMovementTask<ITroop>
	{
		public BBParameter<Vector3> position;

		protected override Vector3 Position => position.value;
	}
}