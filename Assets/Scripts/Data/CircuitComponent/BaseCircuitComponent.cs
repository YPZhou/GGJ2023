using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static Constants;

public abstract class BaseCircuitComponent : MonoBehaviour
{

	protected new Animation animation;
	
	protected void Awake()
	{
		animation = GetComponent<Animation>();
		
		SetupConnectedTiles();
	}

	protected void Start()
	{
		transform.localPosition = bottomLeftPosition + new Vector3(TileCoords.Item1 - 1, TileCoords.Item2 - 1);
		transform.localRotation = Quaternion.AngleAxis(90 * rotationCount, Vector3.back);

		previousRotationCount = rotationCount;
	}

	protected void Update()
	{
		transform.localPosition = bottomLeftPosition + new Vector3(TileCoords.Item1 - 1, TileCoords.Item2 - 1);

		if (previousRotationCount != rotationCount)
		{
			transform.localRotation = Quaternion.AngleAxis(90 * previousRotationCount + 360 * (Time.time - rotationStartTime), Vector3.back);

			if (Time.time - rotationStartTime >= 0.25f)
			{
				previousRotationCount = rotationCount;
			}
		}

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

	float rotationStartTime = 0f;
	int previousRotationCount = 0;
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
		previousRotationCount = rotationCount;
		rotationCount += 1;
		if (rotationCount > 3)
		{
			rotationCount = 0;
		}

		rotationStartTime = Time.time;
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

	public bool IsHovered { get; set; }
}
