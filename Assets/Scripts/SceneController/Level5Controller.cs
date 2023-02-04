using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5Controller : BaseLevelController
{
	protected override void UpdateCore()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("GameTitle");
		}
	}
}
