using System;
using UnityEngine;
using static Constants;

public class InputComponent : BaseCircuitComponent
{
	public override ComponentType ComponentType => ComponentType.INPUT;

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
	}

	protected override void UpdateCore()
	{
		if (IsConnected)
		{
			if (connectedMark != null)
			{
				connectedMark.enabled = true;
			}

			if (disconnectedMark != null)
			{
				disconnectedMark.enabled = false;
			}
		}
		else
		{
			if (connectedMark != null)
			{
				connectedMark.enabled = false;
			}

			if (disconnectedMark != null)
			{
				disconnectedMark.enabled = true;
			}
		}
	}

	[SerializeField]
	SpriteRenderer connectedMark;

	[SerializeField]
	SpriteRenderer disconnectedMark;
}
