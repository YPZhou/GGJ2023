using System;
using UnityEngine;
using static Constants;

public class NodeComponent : BaseCircuitComponent
{
	public override ComponentType ComponentType => ComponentType.NODE;

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
		ConnectedTiles.Add(new Tuple<int, int>(0, -1));
	}

	protected override void UpdateCore()
	{
		if (cursor != null)
		{
			if (IsHovered)
			{
				cursor.enabled = true;
			}
			else
			{
				cursor.enabled = false;
			}
		}
	}

	[SerializeField]
	SpriteRenderer cursor;
}
