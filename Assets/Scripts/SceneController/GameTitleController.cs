using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTitleController : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			SceneManager.LoadScene("Level1");
		}
	}
}
