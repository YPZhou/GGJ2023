using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Controller : BaseLevelController
{
	protected override void UpdateCore()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Level4");
		}
	}

	protected override string NextLevelName => "Level4";
}
