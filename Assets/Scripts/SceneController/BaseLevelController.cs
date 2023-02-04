using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Constants;

public abstract class BaseLevelController : MonoBehaviour
{
	protected void Start()
	{
		LoadLevelResources();
		InitializeLevelComponents();
	}

	protected virtual void LoadLevelResources()
	{
		levelTile = Resources.Load<GameObject>("Prefabs/LevelTile");
		inputComponent = Resources.Load<GameObject>("Prefabs/Input");
		outputComponent = Resources.Load<GameObject>("Prefabs/Output");
		wireComponent = Resources.Load<GameObject>("Prefabs/Wire");
		turningWireComponent = Resources.Load<GameObject>("Prefabs/TurningWire");
		threeWayWireComponent = Resources.Load<GameObject>("Prefabs/ThreeWayWire");
		nodeComponent = Resources.Load<GameObject>("Prefabs/Node");
		turningNodeComponent = Resources.Load<GameObject>("Prefabs/TurningNode");
		threeWayNodeComponent = Resources.Load<GameObject>("Prefabs/ThreeWayNode");
	}

	protected virtual void InitializeLevelComponents()
	{
		CreateLevelTiles();
	}

	void CreateLevelTiles()
	{
		if (levelTile != null)
		{
			for (var i = 0; i < levelWidth; i++)
			{
				for (var j = 0; j < levelHeight; j++)
				{
					Instantiate(levelTile, BottomLeftPosition + new Vector3(i, j), Quaternion.identity);
				}
			}
		}
	}

	protected void Update()
	{
		if (IsConnected)
		{
			StartCoroutine(StartNextLevelCoroutine());
		}
		else
		{
			UpdateCore();
		}
	}

	protected virtual void UpdateCore()
	{
	}

	IEnumerator StartNextLevelCoroutine()
	{
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene(NextLevelName);
	}

	protected abstract string NextLevelName { get; }

	public Vector3 BottomLeftPosition => new Vector3(-levelWidth / 2, -levelHeight / 2);

	public bool IsConnected
	{
		get
		{
			var result = false;
			var inputComponents = CircuitComponents.Where(component => component.ComponentType == ComponentType.INPUT);
			var outputComponents = CircuitComponents.Where(component => component.ComponentType == ComponentType.OUTPUT);
			if (inputComponents.Any() && outputComponents.Any())
			{
				result = outputComponents.All(outputComponent => inputComponents.Any(inputComponent => HasPath(inputComponent, outputComponent)));
			}

			return result;
		}
	}

	bool HasPath(BaseCircuitComponent originComponent, BaseCircuitComponent targetComponent)
	{
		var openComponents = new List<BaseCircuitComponent>() { originComponent };
		var visitedComponents = new List<BaseCircuitComponent>();

		while (openComponents.Count > 0)
		{
			// Take first open component
			var currentComponent = openComponents[0];

			// Add non-visited connected component to open list
			foreach (var component in CircuitComponents)
			{
				if (component != currentComponent && !visitedComponents.Contains(component))
				{
					if (currentComponent.IsConnected(component))
					{
						openComponents.Add(component);
					}
				}
			}

			// Move current open component to visited list
			visitedComponents.Add(currentComponent);
			openComponents.Remove(currentComponent);
		}

		return visitedComponents.Any(component => component.TileCoords.Item1 == targetComponent.TileCoords.Item1 && component.TileCoords.Item2 == targetComponent.TileCoords.Item2);
	}

	protected List<BaseCircuitComponent> CircuitComponents => circuitComponents ?? (circuitComponents = new List<BaseCircuitComponent>());
	List<BaseCircuitComponent> circuitComponents;

	[SerializeField]
	int levelWidth;

	[SerializeField]
	int levelHeight;

	GameObject levelTile;
	protected GameObject inputComponent;
	protected GameObject outputComponent;
	protected GameObject wireComponent;
	protected GameObject turningWireComponent;
	protected GameObject threeWayWireComponent;
	protected GameObject nodeComponent;
	protected GameObject turningNodeComponent;
	protected GameObject threeWayNodeComponent;
}
