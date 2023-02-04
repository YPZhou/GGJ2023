using System;
using static Constants;

public class OutputComponent : BaseCircuitComponent
{
	public OutputComponent(int coordX, int coordY)
		: base(ComponentType.OUTPUT, coordX, coordY)
	{
	}

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
	}
}
