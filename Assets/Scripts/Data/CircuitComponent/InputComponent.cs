using System;
using static Constants;

public class InputComponent : BaseCircuitComponent
{
	public InputComponent(int coordX, int coordY)
		: base(ComponentType.INPUT, coordX, coordY)
	{
	}

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
	}
}
