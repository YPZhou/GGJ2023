using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    private Button button;
    
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Back);
    }

    void Back()
    {
        var sceneName = SceneManager.GetActiveScene().name;
        if (sceneName.Equals("SelectLevel"))
        {
            SceneManager.LoadScene("GameTitle");
        }
        else if (sceneName.Equals("GameWin"))
        {
			SceneManager.LoadScene("GameTitle");
		}
        else
        {
            SceneManager.LoadScene("SelectLevel");
        }
    }
}