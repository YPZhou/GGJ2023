using UnityEngine;

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
		UpdateCore();
	}

	protected virtual void UpdateCore()
	{
	}

	public Vector3 BottomLeftPosition => new Vector3(-levelWidth / 2, -levelHeight / 2);

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
