using System;
using static Constants;

public class NodeComponent : BaseCircuitComponent
{
	public NodeComponent(int coordX, int coordY)
		: base(ComponentType.NODE, coordX, coordY)
	{
	}

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
		ConnectedTiles.Add(new Tuple<int, int>(0, -1));
	}
}
