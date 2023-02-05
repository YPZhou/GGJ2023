using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTitleController : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			
		}
	}

	public void StartGame()
	{
		SceneManager.LoadScene("SelectLevel");
	}

	public void GameOver()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
	}

}
