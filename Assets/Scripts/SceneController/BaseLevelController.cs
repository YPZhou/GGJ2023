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
	}

	protected virtual void InitializeLevelComponents()
	{
		CreateLevelTiles();
	}

	void CreateLevelTiles()
	{
		if (levelTile != null)
		{
			// Calculate top-left position
			var topLeftPosition = new Vector3(-levelWidth / 2, -levelHeight / 2);

			for (var i = 0; i < levelWidth; i++)
			{
				for (var j = 0; j < levelHeight; j++)
				{
					Instantiate(levelTile, topLeftPosition + new Vector3(i, j), Quaternion.identity);
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

	[SerializeField]
	int levelWidth;

	[SerializeField]
	int levelHeight;

	GameObject levelTile;
}
