using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevelPanel : MonoBehaviour
{
    [SerializeField]
    public List<SceneAsset> levels;

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
                OpenLevel(level.name);
            });
            text.text = level.name;

        }
    }

    void OpenLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

}