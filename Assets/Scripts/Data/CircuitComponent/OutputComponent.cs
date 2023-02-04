using System;
using static Constants;

public class OutputComponent : BaseCircuitComponent
{
	public override ComponentType ComponentType => ComponentType.OUTPUT;

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
	}
}
