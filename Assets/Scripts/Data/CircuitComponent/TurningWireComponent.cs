using System;
using static Constants;

public class TurningWireComponent : BaseCircuitComponent
{
	public override ComponentType ComponentType => ComponentType.WIRE;

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
		ConnectedTiles.Add(new Tuple<int, int>(1, 0));
	}
}
