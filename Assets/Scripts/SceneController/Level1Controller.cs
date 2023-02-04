using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Controller : BaseLevelController
{
	protected override void UpdateCore()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Level2");
		}
	}
}
