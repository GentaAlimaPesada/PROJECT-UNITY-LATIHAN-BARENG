using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string MenuScene;
    public string InGameScene;
    public string SettingScene;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(MenuScene);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene(InGameScene);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(SettingScene);
        }
    }
}
