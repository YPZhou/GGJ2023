using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4Controller : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Level5");
		}
	}
}
