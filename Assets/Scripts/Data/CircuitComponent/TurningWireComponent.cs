using System;
using static Constants;

public class TurningWireComponent : BaseCircuitComponent
{
	public TurningWireComponent(int coordX, int coordY)
		: base(ComponentType.WIRE, coordX, coordY)
	{
	}

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
		ConnectedTiles.Add(new Tuple<int, int>(1, 0));
	}
}
