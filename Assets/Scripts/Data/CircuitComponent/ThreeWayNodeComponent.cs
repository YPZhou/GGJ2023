using System;
using static Constants;

public class ThreeWayNodeComponent : BaseCircuitComponent
{
	public ThreeWayNodeComponent(int coordX, int coordY)
		: base(ComponentType.NODE, coordX, coordY)
	{
	}

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
		ConnectedTiles.Add(new Tuple<int, int>(1, 0));
		ConnectedTiles.Add(new Tuple<int, int>(-1, 0));
	}
}
