using System;

public static class Extensions
{
	public static Tuple<int, int> RotateClockwise(this Tuple<int, int> coords)
	{
		return new Tuple<int, int>(coords.Item2, -coords.Item1);
	}
}
