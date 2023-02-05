using System;
using UnityEngine;
using static Constants;

public class OutputComponent : BaseCircuitComponent
{
	public override ComponentType ComponentType => ComponentType.OUTPUT;

	protected override void SetupConnectedTiles()
	{
		ConnectedTiles.Add(new Tuple<int, int>(0, 1));
	}

	protected override void UpdateCore()
	{
		if (connectedMark != null)
		{
			connectedMark.transform.rotation = Quaternion.identity;
		}

		if (disconnectedMark != null)
		{
			disconnectedMark.transform.rotation = Quaternion.identity;
		}

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
