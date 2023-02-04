using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Controller : BaseLevelController
{
	protected override void UpdateCore()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Level3");
		}
	}

	protected override string NextLevelName => "Level3";
}
