using System;
using static Constants;

public class InputComponent : BaseCircuitComponent
{
	public override Constants.ComponentType ComponentType => ComponentType.INPUT;

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
	}
}
