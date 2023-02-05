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
			if (cabinet_on != null)
            {
				gameObject.GetComponent<SpriteRenderer>().sprite = cabinet_on;
            }

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
			if (cabinet_off != null)
			{
				gameObject.GetComponent<SpriteRenderer>().sprite = cabinet_off;
			}

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

	[SerializeField]
	Sprite cabinet_off;
	[SerializeField]
	Sprite cabinet_on;
}
