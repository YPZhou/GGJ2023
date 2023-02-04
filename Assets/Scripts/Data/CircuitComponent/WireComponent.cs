using System;
using static Constants;

public class WireComponent : BaseCircuitComponent
{
	public WireComponent(int coordX, int coordY)
		: base(ComponentType.WIRE, coordX, coordY)
	{
	}

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
		ConnectedTiles.Add(new Tuple<int, int>(0, -1));
	}
}
