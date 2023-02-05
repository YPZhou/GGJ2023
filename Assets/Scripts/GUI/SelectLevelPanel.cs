using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevelPanel : MonoBehaviour
{
    [SerializeField]
    public List<string> levels;

    [SerializeField]
    public GameObject buttonPrefab;


    private void Awake()
    {
        foreach (var level in levels)
        {
            var obj = Instantiate(buttonPrefab, transform, true);
            var button = obj.GetComponent<Button>();
            var textObj = obj.transform.GetChild(0);
            var text = textObj.GetComponent<Text>();

            button.onClick.AddListener(() =>
            {
                OpenLevel(level);
            });
            text.text = string.Format("·þÎñÆ÷ {0}", level.Substring(5));

        }
    }

    void OpenLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }


}