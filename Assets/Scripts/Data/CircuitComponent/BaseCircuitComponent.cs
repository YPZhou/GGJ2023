using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static Constants;

public abstract class BaseCircuitComponent : MonoBehaviour
{
	protected void Awake()
	{
		SetupConnectedTiles();
	}

	protected void Update()
	{
		transform.localPosition = bottomLeftPosition + new Vector3(TileCoords.Item1 - 1, TileCoords.Item2 - 1);
		transform.localRotation = Quaternion.AngleAxis(90 * rotationCount, Vector3.back);

		UpdateCore();
	}

	protected virtual void UpdateCore()
	{
	}

	public abstract ComponentType ComponentType { get; }

	public void SetCoords(int coordX, int coordY)
	{
		TileCoords = new Tuple<int, int>(coordX, coordY);
	}

	public void SetLevelBottomLeftPosition(Vector3 bottomLeftPosition)
	{
		this.bottomLeftPosition = bottomLeftPosition;
	}

	protected Vector3 bottomLeftPosition;

	public Tuple<int, int> TileCoords { get; protected set; }

	int rotationCount = 0;

	protected IEnumerable<Tuple<int, int>> CalculatedConnectedTiles => ConnectedTiles.Select(tile =>
	{
		var result = new Tuple<int, int>(tile.Item1, tile.Item2);
		for (var i = 0; i < rotationCount; i++)
		{
			result = result.RotateClockwise();
		}
		result = new Tuple<int, int>(TileCoords.Item1 + result.Item1, TileCoords.Item2 + result.Item2);

		return result;
	});

	protected List<Tuple<int, int>> ConnectedTiles => connectedTiles ?? (connectedTiles = new List<Tuple<int, int>>());
	List<Tuple<int, int>> connectedTiles;

	protected abstract void SetupConnectedTiles();

	public void RotateClockwise()
	{
		rotationCount += 1;
		if (rotationCount > 3)
		{
			rotationCount = 0;
		}
	}

	public void Swap(BaseCircuitComponent otherComponent)
	{
		var tempCoords = TileCoords;
		TileCoords = new Tuple<int, int>(otherComponent.TileCoords.Item1, otherComponent.TileCoords.Item2);
		otherComponent.TileCoords = new Tuple<int, int>(tempCoords.Item1, tempCoords.Item2);
	}

	public bool IsAdjacent(BaseCircuitComponent otherComponent) => CalculatedConnectedTiles.Contains(otherComponent.TileCoords) && otherComponent.CalculatedConnectedTiles.Contains(TileCoords);

	public void SetConnectivity(bool isConnected)
	{
		IsConnected = isConnected;
	}

	public bool IsConnected { get; private set; }
}
