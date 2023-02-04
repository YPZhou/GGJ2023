using System;
using static Constants;

public class TurningNodeComponent : BaseCircuitComponent
{
	public override ComponentType ComponentType => ComponentType.NODE;

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
		ConnectedTiles.Add(new Tuple<int, int>(1, 0));
	}
}